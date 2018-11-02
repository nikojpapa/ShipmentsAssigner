namespace ShipmentsAssigner
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Primitive;
    open Utils.General;
    open Utils.Compare;
    open Utils.Math;

    // each node consists of registers: |id>|shipmentId>|time>|coordinates>

    newtype NodeRegisterLengths = (Int, Int, Int, Int);
    newtype Node = (Qubit[], Int, Int, Int);

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

    operation _GetQuantumIndexImpl(control: Qubit, database: LittleEndian, qubits: Qubit[]): Unit {
        body (...) {
            let windowSize = Length(database!);
            let halfWindowSize = windowSize / 2;
            let isEven = windowSize % 2 == 0;

            let sliceFunc = Slice(database!, _, _, _);
            let sliceLower = Controlled sliceFunc(_, (0, halfWindowSize - 1, _));
            let sliceUpper = Controlled sliceFunc(_, (halfWindowSize, windowSize - 1, _));

            sliceLower([control], Most(qubits));
            X(control);
            if (isEven) {
                sliceUpper([control], Most(qubits));
            } else {
                sliceUpper([control], qubits);
            }
            X(control);
        }

        adjoint invert;
    }

    operation GetQuantumIndex(qIndex: Qubit[], database: LittleEndian, target: Qubit[], depth: Int): Unit {
        Message($"depth: {depth}");
        if (Length(qIndex) == depth) {
            CNOT(database![0], target[0]);
        } else {
            let windowSize = Length(database!);
            let halfWindowSize = windowSize / 2;
            let isEven = windowSize % 2 == 0;
            let control = qIndex[depth];

            using (qubits = Qubit[halfWindowSize + 1]) {
                let qubitsLength = Length(qubits);
                Message($"qubits length: {qubitsLength}");
                _GetQuantumIndexImpl(control, database, qubits);
                // let sliceFunc = Slice(arr!, _, _, qubits);
                // Controlled sliceFunc([control], (0, halfWindowSize - 1));
                // X(control);
                // Controlled sliceFunc([control], (halfWindowSize, windowSize - 1));
                // X(control);

                GetQuantumIndex(qIndex, LittleEndian(qubits), target, depth + 1);

                Adjoint _GetQuantumIndexImpl(control, database, qubits);
                // X(control);
                // Adjoint Controlled sliceFunc([control], (halfWindowSize, windowSize - 1));
                // X(control);
                // Adjoint Controlled sliceFunc([control], (0, halfWindowSize - 1));
            }
        }
    }

    operation _TestGetQuantumIndexImpl(qIndex: Qubit[], length: Int): Unit {
        let cIndex = QubitsToInt(qIndex);
        let maxIndex = 2 ^ Length(qIndex) - 1;
        Message($"index: {cIndex}");

        mutable cDatabase = new Int[maxIndex];
        mutable databaseStr = "";
        for (i in 0..maxIndex - 1) {
            set cDatabase[i] = RandomInt(2);
            set databaseStr = databaseStr + ToStringI(cDatabase[i]);
        }
        Message($"database: {databaseStr}");

        using ((qDatabase, target) = (Qubit[maxIndex], Qubit[1])) {
            SetQubits(qDatabase, cDatabase);

            GetQuantumIndex(qIndex, LittleEndian(qDatabase), target, 0);

            let calcAns = QubitsToInt(target);
            let trueAns = cDatabase[cIndex];
            AssertIntEqual(calcAns, trueAns, $"{calcAns} != {trueAns}");
            Message($"{calcAns} == {trueAns}");
            Message("");

            ResetAll(qDatabase + target);
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
