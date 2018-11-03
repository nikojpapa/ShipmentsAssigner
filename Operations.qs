namespace ShipmentsAssigner
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Primitive;
    open Utils.General;
    open Utils.Compare;
    open Utils.Math;
    open Utils.Testing;

    // each node consists of registers: |id>|shipmentId>|time>|coordinates>

    newtype DatabaseEntry = (Int, Int, Int); // [shipmentId, time, coordinates]
    newtype Database = DatabaseEntry[];
    newtype NodeRegisterLengths = (Int, Int, Int, Int);
    newtype Node = (Qubit[], Int, Int, Int);
    newtype Window = (Int, Int);

    function GetDatabase(): Database {
        return Database([
            DatabaseEntry(1, 1, 1),
            DatabaseEntry(2, 2, 2),
            DatabaseEntry(3, 3, 3)
        ]);
    }

    operation TimesAreValid (nodes: Node[], target: Qubit): Unit {  // flips target if invalid
        body (...) {
            let numNodes = Length(nodes);
            using (control = Qubit[BitSize(numNodes)]) {
                X(Tail(control));

                mutable lastTime = -1;
                for (node in nodes) {
                    let (nodeId, shipmentId, time, coordinates) = node!;
                    if (lastTime <= time) {
                        QFTAdderInt(control, -1);
                    }

                    ApplyToEachCA(X, control);
                    Controlled X(control, target);
                    ApplyToEachCA(X, control);

                    set lastTime = time;
                }

                set lastTime = -1;
                for (node in nodes) {
                    let (nodeId, shipmentId, time, coordinates) = node!;
                    if (lastTime <= time) {
                        QFTAdderInt(control, 1);
                    }

                    set lastTime = time;
                }
            }
        }
    }

    operation Slice(arr: Qubit[], startIndex: Int, endIndex: Int, target: Qubit[]): Unit {
        body (...) {
            let targetLength = Length(target);
            let sliceLength = endIndex - startIndex + 1;
            AssertIntEqual(Length(target), endIndex - startIndex + 1, $"target not correct length; targetLength: {targetLength}, sliceLength: {sliceLength}");
            
            let slicedArr = arr[startIndex..endIndex];
            for (i in 0..Length(slicedArr) - 1) {
                CNOT(slicedArr[i], target[i]);
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    // operation _GetQuantumIndexImpl(control: Qubit, window: Window, seenIndex: Int, qIndexLength: Int, recursiveCall: ((Window, Int) => Unit: Controlled, Adjoint)): Unit {
    //     body (...) {
    //         let (windowMin, windowMax) = window!;
    //         let testIndex = (windowMin + windowMax) / 2;
    //         let windowIsEven = (windowMax - windowMax) % 2 == 1;
    //         let addToIndex = 2 ^ (qIndexLength - 1);

    //         recursiveCall(Window(testIndex + 1, windowMax), seenIndex + addToIndex);
    //         X(control);
    //         // if (windowIsEven) {
    //         //     recursiveCall(Window(windowMin, testIndex), seenIndex);
    //         // } else {
    //             recursiveCall(Window(windowMin, testIndex - 1), seenIndex);
    //         // }
    //         X(control);
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }

    operation GetElementUsingQuantumIndex(qIndex: Qubit[], database: Int[], target: Qubit[]): Unit {
        body (...) {
            for (i in 0..2 ^ Length(qIndex) - 1) {
                using(qubits = Qubit[1]) {
                    let toggle = qubits[0];
                    XIfQubitEqualToInt(qIndex, i, toggle);
                    Controlled QFTAdderInt([toggle], (target, database[i]));
                    XIfQubitEqualToInt(qIndex, i, toggle);
                }
            }

            // let (windowMin, windowMax) = window!;
            // let testIndex = (windowMin + windowMax) / 2;
            
            // Message($"windowMin: {windowMin}, windowMax: {windowMax}, testIndex: {testIndex}, seenIndex: {seenIndex}");
            // if (seenIndex == testIndex) {
            //     Message($"setting {database[testIndex]} from index {testIndex}");
            //     QFTAdderInt(target, database[testIndex]);
            // } else {
            //     let control = qIndex[0];
            //     let qIndexLength = Length(qIndex);

            //     let recursiveCall = Controlled GetElementUsingQuantumIndex([control], (_, database, target, _, _));
            //     if (Length(qIndex) > 1) {
            //         _GetQuantumIndexImpl(control, window, seenIndex, qIndexLength, recursiveCall(qIndex[1..Length(qIndex) - 1], _, _));
            //         // Adjoint _GetQuantumIndexImpl(control, qIndex, target, window, recursiveCall(qIndex[1..Length(qIndex) - 1], _));
            //     } else {
            //         _GetQuantumIndexImpl(control, window, seenIndex, qIndexLength, recursiveCall(new Qubit[0], _, _));
            //         // Adjoint _GetQuantumIndexImpl(control, qIndex, target, window, recursiveCall(new Qubit[0], _));
            //     }
            // }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation _TestGetQuantumIndexImpl(qIndex: Qubit[], length: Int): Unit {
        let cIndex = QubitsToInt(qIndex);
        let maxIndex = 2 ^ Length(qIndex) - 1;
        let dbLength = maxIndex + 1;
        Message($"index: {cIndex}");

        mutable cDatabase = new Int[dbLength];
        // mutable databaseStr = "";
        for (i in 0..dbLength - 1) {
            set cDatabase[i] = i;
            // set cDatabase[i] = RandomInt(2);
            // set databaseStr = databaseStr + ToStringI(cDatabase[i]);
        }
        Message($"{cDatabase}");

        using (target = Qubit[BitSize(dbLength)]) {
            GetElementUsingQuantumIndex(qIndex, cDatabase, target);

            let calcAns = QubitsToInt(target);
            let trueAns = cDatabase[cIndex];
            AssertIntEqual(calcAns, trueAns, $"{calcAns} != {trueAns}");
            Message($"{calcAns} == {trueAns}");
            Message("");

            ResetAll(target);
        }
    }

    operation _TestGetQuantumIndex(length: Int): Unit {
        RunOnAllBinariesOfLength(length, _TestGetQuantumIndexImpl(_, length));
    }

    function _DatabaseEntryToArray(databaseEntry: DatabaseEntry): Int[] {
        let (shipmentId, time, coordinates) = databaseEntry!;
        return [shipmentId, time, coordinates];
    }

    function GetShipmentIdFromDatabaseEntry(databaseEntry: DatabaseEntry): Int {
        return (_DatabaseEntryToArray(databaseEntry))[0];
    }

    function GetTimeFromDatabaseEntry(databaseEntry: DatabaseEntry): Int {
        return (_DatabaseEntryToArray(databaseEntry))[1];
    }

    function GetCoordinatesFromDatabaseEntry(databaseEntry: DatabaseEntry): Int {
        return (_DatabaseEntryToArray(databaseEntry))[2];
    }

    function GetCategorizedEntries(database: Database): Int[][] {
        let databaseEntriesInArr = Map(_DatabaseEntryToArray, database!);
        let numProperties = Length(databaseEntriesInArr);

        mutable categorized = new Int[][numProperties];
        for (i in 0..Length(databaseEntriesInArr)) {
            let entry = databaseEntriesInArr[i];
            for (j in 0..numProperties - 1) {
                set categorized[j] = categorized[j] + [entry[j]];
            }
        }

        return categorized;
    }

    function GetElementLengths(database: Database): Int[] {
        let databaseEntriesInArr = Map(_DatabaseEntryToArray, database!);
        let numProperties = Length(databaseEntriesInArr);

        let categorized = GetCategorizedEntries(database);

        mutable lengths = new Int[numProperties];
        for (i in 0..numProperties - 1) {
            set lengths[i] = BitSize(Max(categorized[i]));
        }

        return lengths;
    }

    operation LoadStopsInSpecifiedOrder(qIndices: Qubit[][], database: Database, target: Qubit[][]): Unit {
        let elementLengths = GetElementLengths(database);
        let categorized = GetCategorizedEntries(database);
        for (i in 0..Length(qIndices) - 1) {
            let qIndex = qIndices[i];
            let entryTarget = target[i];

            mutable startIndex = 0;
            for (j in 0..Length(elementLengths) - 1) {
                let endIndex = startIndex + elementLengths[j] - 1;
                let elementTarget = entryTarget[startIndex..endIndex];

                GetElementUsingQuantumIndex(qIndex, categorized[j], elementTarget);

                set startIndex = endIndex + 1;
            }
        }
    }

    // operation GetElement (startIndex: Qubit[], length: Int, target: Qubit[]): () {

    // }

    // operation _TestTimesAreValidImpl(qubits: Qubit[], numLocations: Int): Unit {
    //     let locationIndexBitSize = BitSize(numLocations);

    //     mutable nodes = new Node[numLocations];
    //     for (i in 0..numLocations - 1) {
    //         let indexStart = locationIndexBitSize * i;
    //         let indexEnd = indexStart + locationIndexBitSize;
    //         set nodes[i] = Node(qubits[indexStart..indexEnd], i, i, i);
    //     }
    // }
    // operation _TestTimesAreValid(numLocations: Int): Unit {
    //     RunOnAllBinariesOfLength(BitSize(numLocations) * numLocations, _TestTimesAreValidImpl(_, numLocations));
    // }

    // operation PhysicallyValid (nodes: Node[], lengths: NodeRegisterLengths) : Unit {
    //     body (...) {
    //         let (idLength, shipmentIdLength, timeLength, coordinateLength) = lengths!;
    //         let totalNodeLength = idLength + shipmentIdLength + timeLength + coordinateLength;
    //         let numNodes = Length(nodes);

    //         mutable lastTime = ();
    //         mutable lastCoordinates = ();
    //         for (node in nodes) {
    //             let (nodeId, shipmentId, time, coordinates) = node!;
    //             set lastTime = time;
    //         }
    //     }
    // }

    // operation Oracle (pickups: Qubit[], deliveries: Qubit[]): Unit {
    //     body (...) {

    //     }
    // }

    // operation Entry () : Unit {
    //     let numPickups = 3;
    //     let indicesLength = numPickups * BitSize(numPickups);
    //     using ((pickups, deliveries) = (Qubit[indicesLength], Qubit[indicesLength])) {

    //     }
    // }
}
