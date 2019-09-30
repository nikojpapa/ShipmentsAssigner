namespace ShipmentsAssigner
{
    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Diagnostics;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Oracles;
    open Utils.General;
    open Utils.Compare;
    open Utils.Math;

    // each node consists of registers: |id>|shipmentId>|time>|coordinates>

    newtype DatabaseEntry = (Int, Int, Int); // [shipmentId, time, coordinates]
    newtype Database = DatabaseEntry[];
    newtype NodeRegisterLengths = (Int, Int, Int, Int);
    newtype Node = (Qubit[], Int, Int, Int);
    // newtype Window = (Int, Int);

    function GetTimeIndex(): Int {
        return 1;
    }

    operation GetElementUsingQuantumIndex(qIndex: Qubit[], arr: Int[], target: BigEndian): Unit {
        body (...) {
            // Message("qIndex:");
            // DumpRegister((), qIndex);
            for (i in 0..Length(arr) - 1) {
                SwapReverseRegister(target!);  // this is much faster than below block of home grown functions, but the rest of the code is implemented assuming qIndex is BigEndian, even though dump register prints it as LittleEndian
                SwapReverseRegister(qIndex);
                (ControlledOnInt(i, IntegerIncrementLE(arr[i], _)))(qIndex, LittleEndian(target!));
                SwapReverseRegister(qIndex);
                SwapReverseRegister(target!);

                // using(qubits = Qubit[1]) {
                //     let toggle = qubits[0];
                //     XIfQubitEqualToInt(qIndex, i, toggle);
                //     Controlled QFTAdderInt([toggle], (target!, database[i]));
                //     XIfQubitEqualToInt(qIndex, i, toggle);
                // }
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    function DatabaseEntryToArray(databaseEntry: DatabaseEntry): Int[] {
        let (shipmentId, time, coordinates) = databaseEntry!;
        return [shipmentId, time, coordinates];
    }

    function GetCategorizedEntries(database: Database): Int[][] {
        let databaseEntriesInArr = Map(DatabaseEntryToArray, database!);
        let numProperties = Length(databaseEntriesInArr[0]);

        mutable categorized = new Int[][numProperties];
        for (i in 0..Length(databaseEntriesInArr) - 1) {
            let entry = databaseEntriesInArr[i];
            for (j in 0..numProperties - 1) {
                set categorized w/= j <- categorized[j] + [entry[j]];
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
            set lengths w/= i <- BitSize(Max(categorized[i]));
        }

        return lengths;
    }
    
    operation LoadProperty(qIndex: Qubit[], database: Database, target: BigEndian, propertyIndex: Int): Unit {
        body (...) {
            let categorized = GetCategorizedEntries(database);
            let numCategories = Length(categorized);
            let elementLengths = GetPropertyLengths(database);
            let elementTarget = target![0..elementLengths[propertyIndex] - 1];

            GetElementUsingQuantumIndex(qIndex, categorized[propertyIndex], BigEndian(elementTarget));
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    // operation LoadFullStop(qIndex: Qubit[], database: Database, target: BigEndian): Unit {
    //     body (...) {
    //         let categorized = GetCategorizedEntries(database);
    //         let numCategories = Length(categorized);
    //         let elementLengths = GetPropertyLengths(database);

    //         mutable startIndex = 0;
    //         for (i in 0..Length(elementLengths) - 1) {
    //             let endIndex = startIndex + elementLengths[i] - 1;
    //             let elementTarget = target![startIndex..endIndex];

    //             GetElementUsingQuantumIndex(qIndex, categorized[i], BigEndian(elementTarget));

    //             set startIndex = endIndex + 1;
    //         }
    //     }

    //     adjoint (...) {
    //         let categorized = GetCategorizedEntries(database);
    //         let numCategories = Length(categorized);
    //         let elementLengths = GetPropertyLengths(database);

    //         mutable endIndex = ClassicalSum(elementLengths) - 1;
    //         for (i in Length(elementLengths) - 1..-1..0) {
    //             let startIndex = endIndex - elementLengths[i] + 1;
    //             let elementTarget = target![startIndex..endIndex];

    //             Adjoint GetElementUsingQuantumIndex(qIndex, categorized[i], BigEndian(elementTarget));

    //             set endIndex = startIndex - 1;
    //         }
    //     }

    //     controlled distribute;
    //     controlled adjoint distribute;
    // }

    operation _ValidTimes(
            qIndices   : Qubit[][],
            database   : Database,
            lastTime   : BigEndian,
            isInvalidLE: LittleEndian 
            )          : Unit {

        body (...) {
            let numStops = Length(database!);
            let timeLength = Length(lastTime!);

            for (i in 0..numStops - 1) {
                // Message("");
                // Message("last Time");
                // DumpRegister((), lastTime!);

                using ((time, toggles, zeroTests) = (Qubit[timeLength], Qubit[1], Qubit[1])) {
                    SwapReverseRegister(time);
                    let timeBE = BigEndian(time);
                    let invalidToggle = toggles[0];
                    let isNotZero = zeroTests[0];
                    let qIndex = qIndices[i];

                    let loadFunc = LoadProperty(_, database, _, GetTimeIndex());
                    loadFunc(qIndex, timeBE);

                    X(isNotZero);
                    XIfAllZero(qIndex, isNotZero);

                    X(invalidToggle);
                    ApplyRippleCarryComparatorBE(timeBE, lastTime, invalidToggle);

                    Controlled IntegerIncrementLE ([isNotZero, invalidToggle], (1, isInvalidLE));

                    Adjoint ApplyRippleCarryComparatorBE(timeBE, lastTime, invalidToggle);
                    X(invalidToggle);

                    if (i > 0) {
                        X(isNotZero);
                        for (j in 0..i - 1) {
                            let qIndicesToTest = ConcatArrays(qIndices[i - j..i - 1]);
                            let fullControlReg = qIndicesToTest + [isNotZero];
                            (ControlledOnInt(0, Adjoint loadFunc(qIndices[i - j - 1], _)))(fullControlReg, lastTime);
                        }
                        X(isNotZero);
                    }
                    for (j in 0..Length(lastTime!) - 1) {
                        Controlled SWAP([isNotZero], (lastTime![j], time[j]));
                    }

                    XIfAllZero(qIndex, isNotZero);
                    X(isNotZero);
                }
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    // operation _OracleImpl (
    //         numStops        : Int, 
    //         targetLength    : Int, 
    //         qIndices        : Qubit[][], 
    //         database        : Database, 
    //         shipmentIdLength: Int, 
    //         timeLength      : Int, 
    //         lastTime        : BigEndian, 
    //         isInvalidLE     : LittleEndian, 
    //         lastTarget      : Qubit[]
    //         )               : Unit {

    //     body (...) {
    //         for (i in 0..numStops - 1) {
    //             using ((target, toggles, zeroTests) = (Qubit[targetLength], Qubit[1], Qubit[1])) {
    //                 let invalidToggle = toggles[0];
    //                 let isNotZero = zeroTests[0];
    //                 let qIndex = qIndices[i];
    //                 let time = BigEndian(target[shipmentIdLength..shipmentIdLength + timeLength - 1]);

    //                 // Message("");
    //                 // Message("qIndex:");
    //                 // DumpRegister((), qIndex);

    //                 let loadFunc = LoadFullStop(_, database, _);
    //                 loadFunc(qIndex, BigEndian(target));

    //                 // Message("");
    //                 // Message("loaded: ");
    //                 // DumpRegister((), target);

    //                 // Message("");
    //                 // Message("last time: ");
    //                 // DumpRegister((), lastTime!);

    //                 // Message("");
    //                 // Message("current time: ");
    //                 // DumpRegister((), time!);

    //                 X(isNotZero);
    //                 XIfAllZero(qIndex, isNotZero);

    //                 X(invalidToggle);
    //                 ApplyRippleCarryComparatorBE(time, lastTime, invalidToggle);

                    
    //                 // Message("");
    //                 // Message("is not null: ");
    //                 // DumpRegister((), [isNotZero]);
                    
    //                 // Message("");
    //                 // Message("invalidToggle: ");
    //                 // DumpRegister((), [invalidToggle]);

    //                 Controlled IntegerIncrementLE ([isNotZero, invalidToggle], (1, isInvalidLE));

    //                 Adjoint ApplyRippleCarryComparatorBE(time, lastTime, invalidToggle);
    //                 X(invalidToggle);

    //                 if (i > 0) {
    //                     X(isNotZero);
    //                     for (j in 0..i - 1) {
    //                         let qIndicesToTest = ConcatArrays(qIndices[i - j..i - 1]);
    //                         let fullControlReg = qIndicesToTest + [isNotZero];
    //                         // Message("");
    //                         // Message($"i: {i}, j: {j}");
    //                         // Message("qIndicesToTest: ");
    //                         // if (Length(qIndicesToTest) > 0) {
    //                         //     DumpRegister((), qIndicesToTest);
    //                         // }
    //                         // Message("");
    //                         // Message("full control reg: ");
    //                         // DumpRegister((), fullControlReg);
    //                         (ControlledOnInt(0, Adjoint loadFunc(qIndices[i - j - 1], _)))(fullControlReg, BigEndian(lastTarget));
    //                     }
    //                     X(isNotZero);
    //                 }
    //                 for (j in 0..targetLength - 1) {
    //                     Controlled SWAP([isNotZero], (lastTarget[j], target[j]));
    //                 }

    //                 XIfAllZero(qIndex, isNotZero);
    //                 X(isNotZero);
    //             }
    //         }
    //     }

    //     adjoint invert;
    //     controlled distribute;
    //     controlled adjoint distribute;
    // }

    function CreateIndices(
            qubits         : Qubit[],
            numStops       : Int, 
            lenIndex       : Int, 
            numProperties  : Int, 
            propertyLengths: Int[]
            )              : Qubit[][] {

        mutable qIndices = new Qubit[][numStops];
        for (i in 0..numStops - 1) {
            let startIndex = i * lenIndex;
            let endIndex = startIndex + lenIndex - 1;

            set qIndices w/= i <- qubits[startIndex..endIndex];
        }

        return qIndices;
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

            let qIndices = CreateIndices(qubits, numStops, lenIndex, numProperties, propertyLengths);

            let targetLength = SumIntArray(propertyLengths);

            using ((lastTime, inValid) = (Qubit[propertyLengths[1]], Qubit[BitSize(numStops)])) {
                let lastTimeBE = BigEndian(lastTime);
                let inValidLE = LittleEndian(inValid);

                _ValidTimes(qIndices, database, lastTimeBE, inValidLE);
                
                XIfAllZero(inValid, ancilla);
                
                Adjoint _ValidTimes(qIndices, database, lastTimeBE, inValidLE);
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation OracleAugmented (
            qubits  : Qubit[], 
            database: Database,
            ancilla : Qubit,
            aug     : Qubit
            )       : Unit {

        body (...) {
            // using ((ancillae, toggles) = (Qubit[1], Qubit[1])) {
            //     let ancilla = ancillae[0];
            //     let toggle = toggles[0];

            //     X(ancilla);
            //     H(ancilla);
                
            //     // Oracle(qubits, database, toggle);

            //     // Controlled X([aug, toggle], ancilla);

            //     // Adjoint Oracle(qubits, database, toggle);

            //     // Controlled X (qubits, ancilla);

            //     X(qubits[2]);
            //     Controlled X (qubits, ancilla);
            //     X(qubits[2]);
            //     X(qubits[1]);
            //     Controlled X (qubits, ancilla);
            //     X(qubits[1]);

            //     H(ancilla);
            //     X(ancilla);
            // }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation GroverStateAugmentedOracle(flagIndex: Int, qubits: Qubit[], database: Database): Unit {  // aug is last qubit
        body (...) {
            let flag = qubits[flagIndex];
            let stateQubits = Exclude([flagIndex], qubits);

            ApplyToEachCA(H, stateQubits);
            OracleAugmented(Most(stateQubits), database, flag, Tail(stateQubits));
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation GroverPow(power: Int, qubits: Qubit[], database: Database): Unit {  // set flag index to 0
        body (...) {
            // using (ancillae = Qubit[1]) {
                let ancilla = qubits[0];
                let stateQubits = qubits[1..Length(qubits) - 1];
                let aug = Tail(qubits);
                let ans = Most(qubits);
                for (i in 1..power) {
                    // Message($"  {i}");
                    OracleAugmented(ans, database, ancilla, aug);  // Grover iteration

                    // DumpMachine();
                    ApplyToEachCA(H, qubits);
                    ApplyToEachCA(X, qubits);
                    // for (j in 1..2 ^ (Length(ans)) - 1) {
                    //     (ControlledOnInt(j, Z))(ans, aug);
                    // }
                    Controlled Z(ans, aug);
                    ApplyToEachCA(X, qubits);
                    ApplyToEachCA(H, qubits);
                }
                DumpRegister((), qubits);

            // }
            // let stateOracle = StateOracle(GroverStateAugmentedOracle(_, _, database));
            // (AmpAmpByOracle(power, stateOracle, 0))(qubits);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation CountSolutions(bitAccuracy: Int, maxError: Double, database: Database): Int {
        let numElements = Length(database!);
        let maxDbIndex = numElements - 1;
        let bitsForMaxDbIndex = BitSize(maxDbIndex);
        let lenT = bitAccuracy + CeilLogBase2(2.0 + 1.0 / (2.0 * maxError));
        Message($"t: {lenT}");

        mutable numSolutions = -1;
        using ((control, target) = (Qubit[lenT], Qubit[bitsForMaxDbIndex * numElements + 3])) {
            let controlBE = BigEndian(control);
            let EPR = target[0..1];
            let ancilla = EPR[1];
            let aug = Tail(target);
            let ans = target[2..bitsForMaxDbIndex * numElements + 1];
            let stateQubits = ans + [aug];
            let inputQubits = [ancilla] +  stateQubits;
            let discreteOracle = DiscreteOracle(GroverPow(_, _, database));

            // GroverPow(2, target, database);
            H(ancilla);
            CNOT(ancilla, EPR[0]);

            // ApplyToEachCA(H, control);
            ApplyToEachCA(H, control + stateQubits);
            for (i in 0..0) {
                Message(ToStringI(i));
                Controlled GroverPow([control[Length(control) - 1 - i]], (2 ^ i, inputQubits, database));
            }
            DumpRegister((), control);
            Adjoint QFT(controlBE);

            // ApplyToEachCA(H, target);
            // QuantumPhaseEstimation(discreteOracle, target, controlBE);

            let fiBE = QubitsToInt(control);
            let fi = MeasureInteger(LittleEndian(control));
            Message("fi: "+ ToStringI(fi));
            Message("fiBE: "+ ToStringI(fiBE));

            let numSolutionsD = PowD(Sin(ToDouble(fiBE) / 2.0), 2.0) * ToDouble(2 ^ Length(inputQubits));
            Message("numSolutionsD: " + ToStringD(numSolutionsD));

            // if (RealMod(numSolutionsD - 0.5, 1.0, 0.0) == 0.0) {
            //     set numSolutions = Round(numSolutionsD - 0.5);
            // } else {
                set numSolutions = Round(numSolutionsD);
            // }

            ResetAll(control + target);
        }

        return numSolutions;
    }

    // operation Entry () : Unit {
    //     let numPickups = 3;
    //     let indicesLength = numPickups * BitSize(numPickups);
    //     using ((pickups, deliveries) = (Qubit[indicesLength], Qubit[indicesLength])) {

    //     }
    // }
}
