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

    newtype NodeRegisterLengths = (Int, Int, Int, Int);
    newtype Node = (Qubit[], Int, Int, Int);
    newtype Window = (Int, Int);

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

    // operation _GetQuantumIndexImpl(control: Qubit, window: Window, recursiveCall: ((Window) => Unit: Controlled, Adjoint)): Unit {
    //     body (...) {
    //         let (windowMin, windowMax) = window!;
    //         let testIndex = (windowMin + windowMax) / 2;
    //         let windowIsEven = (windowMax - windowMax) % 2 == 1;

    //         recursiveCall(Window(testIndex + 1, windowMax));
    //         X(control);
    //         if (windowIsEven) {
    //             recursiveCall(Window(windowMin, testIndex));
    //         } else {
    //             recursiveCall(Window(windowMin, testIndex - 1));
    //         }
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
            
            // if (Length(qIndex) == 0) {
            //     QFTAdder(target, [database[testIndex]]);
            // } else {
            //     Message($"windowMin: {windowMin}, windowMax: {windowMax}, testIndex: {testIndex}");
            //     let control = qIndex[0];

            //     let recursiveCall = Controlled GetQuantumIndex([control], (_, database, target, _, currentDepth + 1, maxDepth));
            //     if (Length(qIndex) > 1) {
            //         _GetQuantumIndexImpl(control, window, recursiveCall(qIndex[1..Length(qIndex) - 1], _));
            //         // Adjoint _GetQuantumIndexImpl(control, qIndex, target, window, recursiveCall(qIndex[1..Length(qIndex) - 1], _));
            //     } else {
            //         _GetQuantumIndexImpl(control, window, recursiveCall(new Qubit[0], _));
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
        mutable databaseStr = "";
        for (i in 0..dbLength - 1) {
            set cDatabase[i] = i;
            // set cDatabase[i] = RandomInt(2);
            // set databaseStr = databaseStr + ToStringI(cDatabase[i]);
        }

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
