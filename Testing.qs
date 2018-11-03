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

    // LoadStop
    operation _TestLoadStopImpl(database: Database, qIndex: Qubit[]): Unit {
        let cIndex = QubitsToInt(qIndex);
        let numStops = Length(database!);
        let nullStop = cIndex >= numStops;

        let propertyLengths = GetPropertyLengths(database);
        let numProperties = Length(propertyLengths);

        
        Message("qIndex length: " + ToStringI(Length(qIndex)));
        Message("Index: " + ToStringI(cIndex));
        Message($"num stops: {numStops}");

        mutable targetLength = 0;
        for (i in 0..numProperties - 1) {
            set targetLength = targetLength + propertyLengths[i];
        }

        Message($"target length: {targetLength}");

        using (target = Qubit[targetLength]) {
            LoadStop(qIndex, database, target);

            if (nullStop) {
                AssertAllZero(target);
            } else {
                let trueStop = database![cIndex];
                let stopArray = DatabaseEntryToArray(trueStop);

                mutable startIndex = 0;
                for (i in 0..Length(stopArray) - 1) {
                    Message($"Category: {i}");
                    let endIndex = startIndex + propertyLengths[i] - 1;
                    let calcAns = QubitsToInt(target[startIndex..endIndex]);
                    let trueAns = stopArray[i];
                    AssertIntEqual(calcAns, trueAns, $"{calcAns} != {trueAns}");

                    set startIndex = endIndex + 1;
                }
            }

            ResetAll(target);
        }
    }
    operation _TestLoadStop(): Unit {
        let database = GetDatabase();
        let numElements = Length(database!);
        let maxDbIndex = numElements - 1;
        RunOnAllBinariesOfLength(BitSize(maxDbIndex), _TestLoadStopImpl(GetDatabase(), _));
    }


    // // LoadStopsInSpecifiedOrder
    // operation _TestLoadStopsInSpecifiedOrderImpl(database: Database, elementLength: Int, a: Qubit[]): Unit {
    //     let lenA = Length(a);
    //     let numCategories = Length(GetCategorizedEntries(database));
    //     let numElements = Length(database!);
    //     let lenIndex = lenA / numElements;
    //     Message($"lenA: {lenA}; numCategories: {numCategories}; numElements: {numElements}; lenIndex: {lenIndex}");

    //     mutable qIndices = new Qubit[][numElements];
    //     for (i in 0..numElements - 1) {
    //         let startIndex = i * lenIndex;
    //         let endIndex = startIndex + lenIndex - 1;

    //         set qIndices[i] = a[startIndex..endIndex];
    //     }

    //     let elementLengths = GetPropertyLengths(database);
    //     let targetQubitsNeeded = numElements * elementLength;
    //     let lenTarget = targetQubitsNeeded / numElements;

    //     using(targetQubits = Qubit[targetQubitsNeeded]) {
    //         mutable targets = new Qubit[][numElements];
    //         for (i in 0..numElements - 1) {
    //             let startIndex = i * lenTarget;
    //             let endIndex = startIndex + lenTarget - 1;
    //             set targets[i] = targetQubits[startIndex..endIndex];
    //         }

    //         mutable indexOrder = "";
    //         for (i in 0..numElements - 1) {
    //             set indexOrder = indexOrder + ToStringI(QubitsToInt(qIndices[i]));
    //         }
    //         Message($"Index order: {indexOrder}");

    //         LoadStopsInSpecifiedOrder(qIndices, database, targets);

    //         ResetAll(targetQubits);
    //     }
    // }
    // operation _TestLoadStopsInSpecifiedOrder(): Unit {
    //     let database = GetDatabase();
    //     let numCategories = Length(GetCategorizedEntries(database));
    //     let numElements = Length(database!);
    //     let elementLengths = GetPropertyLengths(database);

    //     mutable totalElementLength = 0;
    //     for (i in 0..numElements - 1) {
    //         set totalElementLength = totalElementLength + elementLengths[i];
    //     }

    //     let totalIndiceQubitsNeeded = BitSize(numElements) * numElements;

    //     RunOnAllBinariesOfLength(totalIndiceQubitsNeeded, _TestLoadStopsInSpecifiedOrderImpl(database, totalElementLength, _));
    // }
}