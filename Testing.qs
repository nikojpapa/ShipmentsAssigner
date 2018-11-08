namespace ShipmentsAssigner {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;
    open Utils.General;
    open Utils.Testing;

    // GET QUANTUM INDEX //
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
            GetElementUsingQuantumIndex(qIndex, cDatabase, BigEndian(target));

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

    // // LoadStop
    // operation _TestLoadStopImpl(database: Database, qIndex: Qubit[]): Unit {
    //     let cIndex = QubitsToInt(qIndex);
    //     let numStops = Length(database!);
    //     let nullStop = cIndex >= numStops;

    //     let propertyLengths = GetPropertyLengths(database);
    //     let numProperties = Length(propertyLengths);

        
    //     Message("qIndex length: " + ToStringI(Length(qIndex)));
    //     Message("Index: " + ToStringI(cIndex));
    //     Message($"num stops: {numStops}");

    //     mutable targetLength = 0;
    //     for (i in 0..numProperties - 1) {
    //         set targetLength = targetLength + propertyLengths[i];
    //     }

    //     Message($"target length: {targetLength}");

    //     using (target = Qubit[targetLength]) {
    //         LoadFullStop(qIndex, database, BigEndian(target));

    //         if (nullStop) {
    //             AssertAllZero(target);
    //         } else {
    //             let trueStop = database![cIndex];
    //             let stopArray = DatabaseEntryToArray(trueStop);

    //             mutable startIndex = 0;
    //             for (i in 0..Length(stopArray) - 1) {
    //                 Message($"Category: {i}");
    //                 let endIndex = startIndex + propertyLengths[i] - 1;
    //                 let calcAns = QubitsToInt(target[startIndex..endIndex]);
    //                 let trueAns = stopArray[i];
    //                 AssertIntEqual(calcAns, trueAns, $"{calcAns} != {trueAns}");

    //                 set startIndex = endIndex + 1;
    //             }
    //         }

    //         ResetAll(target);
    //     }
    // }
    // operation _TestLoadStop(): Unit {
    //     let database = GetDatabase();
    //     let numElements = Length(database!);
    //     let maxDbIndex = numElements - 1;
    //     RunOnAllBinariesOfLength(BitSize(maxDbIndex), _TestLoadStopImpl(GetDatabase(), _));
    // }

    operation _TestOracleImpl(
            database   : Database,
            numElements: Int,
            qubits     : Qubit[])
                       : Unit {

        let qIndexLength = Length(qubits) / numElements;

        // mutable cIndices = new Int[numElements];
        // // mutable qIndices = new Qubit[][numElements];
        // mutable startIndex = 0;
        // for (i in 0..numElements - 1) {
        //     let endIndex = startIndex + qIndexLength - 1;
        //     set cIndices[i] = QubitsToInt(qubits[startIndex..endIndex]);
        //     // set qIndices[i] = qubits[startIndex..endIndex];
        //     set startIndex = endIndex + 1;
        // }

        // Message(IntArrrayToString(cIndices));

        using (ancillas = Qubit[1]) {
            let ancilla = ancillas[0];
            Oracle(qubits, database, ancilla);

            let calcAns = M(ancilla);

            mutable cIndices = new Int[numElements];
            // mutable qIndices = new Qubit[][numElements];
            mutable startIndex = 0;
            for (i in 0..numElements - 1) {
                let endIndex = startIndex + qIndexLength - 1;
                set cIndices[i] = QubitsToInt(qubits[startIndex..endIndex]);
                // set qIndices[i] = qubits[startIndex..endIndex];
                set startIndex = endIndex + 1;
            }

            Message(IntArrrayToString(cIndices));

            let categorized = GetCategorizedEntries(database);
            let times = categorized[1];
            mutable valid = true;
            mutable lastTime = -1;
            for (i in 0..Length(cIndices) - 1) {
                let cIndex = cIndices[i];
                if (cIndex < Length(times)) {
                    let time = times[cIndex];
                    // Message($"cIndex: {cIndex}; time: {time}, lastTime: {lastTime}");
                    if (cIndex > 0 && time <= lastTime) {
                        // Message("setting invalid");
                        set valid = false;
                    }

                    if (cIndex > 0) {
                        set lastTime = time;
                    }
                } else {
                    set valid = false;
                }
            }

            let trueAns = ResultFromBool(valid);

            AssertResultEqual(calcAns, trueAns, "Incorrect. Correct answer is " + ToStringB(valid));
            Message("Correctly " + ToStringB(valid));

            ResetAll(ancillas);
        }        
    }
    operation _TestOracle(numTests: Int): Unit {
        let database = GetDatabase();
        let numElements = Length(database!);
        let maxDbIndex = numElements - 1;

        using (qubits = Qubit[BitSize(maxDbIndex) * numElements]) {
            IntegerIncrementLE(17, LittleEndian(qubits));
            SwapReverseRegister(qubits);
            _TestOracleImpl(database, numElements, qubits);
            ResetAll(qubits);
        }

        RunOnAllBinariesOfLength(BitSize(maxDbIndex) * numElements, _TestOracleImpl(database, numElements, _));

        // using (qubits = Qubit[BitSize(maxDbIndex) * numElements]) {
        //     for (i in 0..numTests - 1) {
        //         QFT(BigEndian(qubits));
        //         _TestOracleImpl(database, numElements, qubits);
        //         ResetAll(qubits);
        //     }
        // }
    }

    operation _TestCountSolutions(maxError: Double): Unit {
        CountSolutions(maxError, GetDatabase());
    }
}