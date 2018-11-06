namespace ShipmentsAssigner
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Diagnostics;
    open Microsoft.Quantum.Primitive;
    open Utils.General;
    open Utils.Compare;
    open Utils.Math;

    // each node consists of registers: |id>|shipmentId>|time>|coordinates>

    newtype DatabaseEntry = (Int, Int, Int); // [shipmentId, time, coordinates]
    newtype Database = DatabaseEntry[];
    newtype NodeRegisterLengths = (Int, Int, Int, Int);
    newtype Node = (Qubit[], Int, Int, Int);
    // newtype Window = (Int, Int);

    function GetDatabase(): Database {
        return Database([
            DatabaseEntry(0, 0, 0),
            DatabaseEntry(1, 1, 1),
            DatabaseEntry(2, 2, 2),
            // DatabaseEntry(3, 3, 3),
            // DatabaseEntry(4, 4, 4),
            // DatabaseEntry(5, 2, 9),
            // DatabaseEntry(9, 15, 13)
        ]);
    }

    operation GetElementUsingQuantumIndex(qIndex: Qubit[], database: Int[], target: BigEndian): Unit {
        body (...) {
            for (i in 0..Length(database) - 1) {
                SwapReverseRegister(target!);
                (ControlledOnInt(i, IntegerIncrementLE(database[i], _)))(qIndex, LittleEndian(target!));
                SwapReverseRegister(target!);
                // using(qubits = Qubit[1]) {
                //     let toggle = qubits[0];
                //     XIfQubitEqualToInt(qIndex, i, toggle);
                //     Controlled QFTAdderInt([toggle], (target, database[i]));
                //     XIfQubitEqualToInt(qIndex, i, toggle);
                // }
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

    function DatabaseEntryToArray(databaseEntry: DatabaseEntry): Int[] {
        let (shipmentId, time, coordinates) = databaseEntry!;
        return [shipmentId, time, coordinates];
    }

    // function GetShipmentIdFromDatabaseEntry(databaseEntry: DatabaseEntry): Int {
    //     return (DatabaseEntryToArray(databaseEntry))[0];
    // }

    // function GetTimeFromDatabaseEntry(databaseEntry: DatabaseEntry): Int {
    //     return (DatabaseEntryToArray(databaseEntry))[1];
    // }

    // function GetCoordinatesFromDatabaseEntry(databaseEntry: DatabaseEntry): Int {
    //     return (DatabaseEntryToArray(databaseEntry))[2];
    // }

    function GetCategorizedEntries(database: Database): Int[][] {
        let databaseEntriesInArr = Map(DatabaseEntryToArray, database!);
        let numProperties = Length(databaseEntriesInArr[0]);

        mutable categorized = new Int[][numProperties];
        for (i in 0..Length(databaseEntriesInArr) - 1) {
            let entry = databaseEntriesInArr[i];
            for (j in 0..numProperties - 1) {
                set categorized[j] = categorized[j] + [entry[j]];
            }
        }

        return categorized;
    }

    function GetPropertyLengths(database: Database): Int[] {
        let databaseEntriesInArr = Map(DatabaseEntryToArray, database!);
        let numProperties = Length(databaseEntriesInArr[0]);

        let categorized = GetCategorizedEntries(database);

        mutable lengths = new Int[numProperties];
        for (i in 0..numProperties - 1) {
            set lengths[i] = BitSize(Max(categorized[i]));
        }

        return lengths;
    }

    operation LoadStop(qIndex: Qubit[], database: Database, target: BigEndian): Unit {
        body (...) {
            let categorized = GetCategorizedEntries(database);
            let numCategories = Length(categorized);
            let elementLengths = GetPropertyLengths(database);

            mutable startIndex = 0;
            for (i in 0..Length(elementLengths) - 1) {
                let endIndex = startIndex + elementLengths[i] - 1;
                let elementTarget = target![startIndex..endIndex];

                GetElementUsingQuantumIndex(qIndex, categorized[i], BigEndian(elementTarget));

                set startIndex = endIndex + 1;
            }
        }

        adjoint (...) {
            let categorized = GetCategorizedEntries(database);
            let numCategories = Length(categorized);
            let elementLengths = GetPropertyLengths(database);

            mutable endIndex = ClassicalSum(elementLengths) - 1;
            for (i in Length(elementLengths) - 1..-1..0) {
                let startIndex = endIndex - elementLengths[i] + 1;
                let elementTarget = target![startIndex..endIndex];

                Adjoint GetElementUsingQuantumIndex(qIndex, categorized[i], BigEndian(elementTarget));

                set endIndex = startIndex - 1;
            }
        }

        controlled distribute;
        controlled adjoint distribute;
    }

    // operation _OracleImplImpl (
    //         isNotZero: Qubit,
    //         qIndex   : Qubit[],
    //         time     : Qubit[],
    //         lastTime : Qubit[],
    //         toggle   : Qubit)
    //                  : Unit {

    //     body (...) {
    //         X(isNotZero);

    //         XIfAllZero(qIndex, isNotZero);

    //         XIfLessThanOrEqual(time, lastTime, toggle);
    //     }

    //     adjoint invert;
    // }

    operation _OracleImpl (
            numStops        : Int, 
            targetLength    : Int, 
            qIndices        : Qubit[][], 
            database        : Database, 
            shipmentIdLength: Int, 
            timeLength      : Int, 
            lastTime        : BigEndian, 
            isInvalidLE     : LittleEndian, 
            lastTarget      : Qubit[]
            )               : Unit {

        body (...) {
            for (i in 0..numStops - 1) {
                using ((target, toggles, zeroTests) = (Qubit[targetLength], Qubit[1], Qubit[1])) {
                    let invalidToggle = toggles[0];
                    let isNotZero = zeroTests[0];
                    let qIndex = qIndices[i];
                    let time = BigEndian(target[shipmentIdLength..shipmentIdLength + timeLength - 1]);

                    let loadFunc = LoadStop(_, database, _);
                    loadFunc(qIndex, BigEndian(target));

                    // Message("");
                    // Message("loaded: ");
                    // DumpRegister((), target);

                    // Message("");
                    // Message("last time: ");
                    // DumpRegister((), lastTime!);

                    // Message("");
                    // Message("current time: ");
                    // DumpRegister((), time!);

                    X(isNotZero);
                    XIfAllZero(qIndex, isNotZero);

                    X(invalidToggle);
                    ApplyRippleCarryComparatorBE(time, lastTime, invalidToggle);

                    
                    // Message("");
                    // Message("is not null: ");
                    // DumpRegister((), [isNotZero]);
                    
                    // Message("");
                    // Message("invalidToggle: ");
                    // DumpRegister((), [invalidToggle]);

                    Controlled IntegerIncrementLE ([isNotZero, invalidToggle], (1, isInvalidLE));

                    Adjoint ApplyRippleCarryComparatorBE(time, lastTime, invalidToggle);
                    X(invalidToggle);

                    if (i > 0) {
                        X(isNotZero);
                        for (j in 0..i - 1) {
                            let qIndicesToTest = ConcatArrays(qIndices[i - j..i - 1]);
                            let fullControlReg = qIndicesToTest + [isNotZero];
                            // Message("");
                            // Message($"i: {i}, j: {j}");
                            // Message("qIndicesToTest: ");
                            // if (Length(qIndicesToTest) > 0) {
                            //     DumpRegister((), qIndicesToTest);
                            // }
                            // Message("");
                            // Message("full control reg: ");
                            // DumpRegister((), fullControlReg);
                            (ControlledOnInt(0, Adjoint loadFunc(qIndices[i - j - 1], _)))(fullControlReg, BigEndian(lastTarget));
                        }
                        X(isNotZero);
                    }
                    for (j in 0..targetLength - 1) {
                        Controlled SWAP([isNotZero], (lastTarget[j], target[j]));
                    }

                    XIfAllZero(qIndex, isNotZero);
                    X(isNotZero);
                }
            }
        }

        adjoint invert;
    }

    operation Oracle (
            qubits  : Qubit[], 
            database: Database, 
            ancilla : Qubit
            )       : Unit {

        body (...) {
            let numStops = Length(database!);
            let lenIndex = Length(qubits) / numStops;

            let propertyLengths = GetPropertyLengths(database);
            let numProperties = Length(propertyLengths);
            let shipmentIdLength = propertyLengths[0];
            let timeLength = propertyLengths[1];
            let coordinatesLength = propertyLengths[2];

            mutable qIndices = new Qubit[][numStops];
            for (i in 0..numStops - 1) {
                let startIndex = i * lenIndex;
                let endIndex = startIndex + lenIndex - 1;

                set qIndices[i] = qubits[startIndex..endIndex];
            }

            mutable targetLength = 0;
            for (i in 0..numProperties - 1) {
                set targetLength = targetLength + propertyLengths[i];
            }

            using ((lastTarget, isValid) = (Qubit[targetLength], Qubit[BitSize(numStops)])) {
                let lastTime = BigEndian(lastTarget[shipmentIdLength..shipmentIdLength + timeLength - 1]);
                let isValidLE = LittleEndian(isValid);
                
                _OracleImpl(numStops, targetLength, qIndices, database, shipmentIdLength, timeLength, lastTime, isValidLE, lastTarget);

                XIfAllZero(isValid, ancilla);

                Adjoint _OracleImpl(numStops, targetLength, qIndices, database, shipmentIdLength, timeLength, lastTime, isValidLE, lastTarget);
            }
        }
    }

    // operation Entry () : Unit {
    //     let numPickups = 3;
    //     let indicesLength = numPickups * BitSize(numPickups);
    //     using ((pickups, deliveries) = (Qubit[indicesLength], Qubit[indicesLength])) {

    //     }
    // }
}
