namespace ShipmentsAssigner
{
    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
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

    ///
    /// This function takes qIndex, a qubit array of states indicating the index to load from the
    /// classical databse, and loads the data from the classical database into the target
    ///
    operation GetElementUsingQuantumIndex(qIndex: Qubit[], arr: Int[], target: BigEndian): Unit {
        body (...) {
            // Message("qIndex:");
            // DumpRegister((), qIndex);
            for (i in 0..Length(arr) - 1) {
                SwapReverseRegister(target!);  // this is much faster than below block of home grown functions, but the rest of the code is implemented assuming qIndex is BigEndian, even though dump register prints it as LittleEndian
                SwapReverseRegister(qIndex);
                (ControlledOnInt(i, IncrementByInteger(arr[i], _)))(qIndex, LittleEndian(target!));
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

    ///
    /// This converts a databse entry from a tuple into an array
    ///
    function DatabaseEntryToArray(databaseEntry: DatabaseEntry): Int[] {
        let (shipmentId, time, coordinates) = databaseEntry!;
        return [shipmentId, time, coordinates];
    }

    /// 
    /// This converts the database entries into separate arrays for each property.
    /// For example, database [[1,2,3], [4,5,6]] would return [[1,4],[2,5],[3,6]]
    /// I.e. Returns the transpose of the database
    /// 
    function GetCategorizedEntries(database: Database): Int[][] {
        let databaseEntriesInArr = Mapped(DatabaseEntryToArray, database!);
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

    ///
    /// For each property of the database, returns the max number of bits needed to store 
    /// the max value of all the entries for that property
    ///
    function GetPropertyLengths(database: Database): Int[] {
        let databaseEntriesInArr = Mapped(DatabaseEntryToArray, database!);
        let numProperties = Length(databaseEntriesInArr[0]);

        let categorized = GetCategorizedEntries(database);

        mutable lengths = new Int[numProperties];
        for (i in 0..numProperties - 1) {
            set lengths w/= i <- BitSizeI(Max(categorized[i]));
        }

        return lengths;
    }
    
    ///
    /// Target register contains the qubits for all properties. This function allocates the number
    /// of qubits needed to contain the max value for that property and loads the qIndex into it 
    ///
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

    ///
    /// For each stop, this first checks that the time is later than the previous node's time, if it 
    /// is not the state of all |0>. It increments the `invalid` register if it is not valid.
    ///
    /// Then, it unloads `lastTime` by performing the adjoint of the previous note, 
    /// then stores the current time in `lastTime` to be compared on the next iteration.
    ///
    /// Since the  `invalid` register is large enough to contain all the stops, if any of the stops
    /// are invalid, the whole sequence is invalid if the register is greater than zero.
    ///
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
                    CompareUsingRippleCarry(BigEndianAsLittleEndian(timeBE), BigEndianAsLittleEndian(lastTime), invalidToggle);

                    Controlled IncrementByInteger ([isNotZero, invalidToggle], (1, isInvalidLE));

                    Adjoint CompareUsingRippleCarry(BigEndianAsLittleEndian(timeBE), BigEndianAsLittleEndian(lastTime), invalidToggle);
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

    ///
    /// Partitions the qubit register into stops
    ///
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

    ///
    /// Marks the ancilla if all of the stops are valid.
    ///
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

            using ((lastTime, inValid) = (Qubit[propertyLengths[1]], Qubit[BitSizeI(numStops)])) {
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
            using (toggles = Qubit[1]) {
                // let ancilla = ancillae[0];
                let toggle = toggles[0];

                X(ancilla);
                H(ancilla);
                
                Oracle(qubits, database, toggle);

                Controlled X([aug, toggle], ancilla);

                Adjoint Oracle(qubits, database, toggle);

                Controlled X (qubits, ancilla);

                // X(qubits[2]);
                // Controlled X (qubits, ancilla);
                // X(qubits[2]);
                // X(qubits[1]);
                // Controlled X (qubits, ancilla);
                // X(qubits[1]);

                H(ancilla);
                X(ancilla);
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    // operation GroverStateAugmentedOracle(flagIndex: Int, qubits: Qubit[], database: Database): Unit {  // aug is last qubit
    //     body (...) {
    //         let flag = qubits[flagIndex];
    //         let stateQubits = Exclude([flagIndex], qubits);

    //         ApplyToEachCA(H, stateQubits);
    //         OracleAugmented(Most(stateQubits), database, flag, Tail(stateQubits));
    //     }

    //     adjoint invert;
    //     controlled distribute;
    //     controlled adjoint distribute;
    // }

    operation GroverPow(power: Int, qubits: Qubit[], database: Database): Unit {  // set flag index to 0
        body (...) {
            let ancilla = qubits[0];
            let inputQubits = qubits[1..Length(qubits) - 1];
            let aug = Tail(inputQubits);
            let ans = Most(inputQubits);

            for (i in 1..power) {
                Oracle(ans, database, ancilla);  // Grover iteration
                ApplyToEachCA(H, inputQubits);
                ApplyToEachCA(X, inputQubits);
                Controlled Z(Most(inputQubits), Tail(inputQubits));
                ApplyToEachCA(X, inputQubits);
                R(PauliI, 2.0 * PI(), qubits[0]);
                ApplyToEachCA(H, inputQubits);
            }
            // // using (ancillae = Qubit[1]) {
            //     let ancilla = qubits[0];
            //     let stateQubits = qubits[1..Length(qubits) - 1];
            //     let aug = Tail(qubits);
            //     let ans = Most(qubits);
            //     for (i in 1..power) {
            //         // Message($"  {i}");
            //         OracleAugmented(ans, database, ancilla, aug);  // Grover iteration

            //         // DumpMachine();
            //         ApplyToEachCA(H, qubits);
            //         ApplyToEachCA(X, qubits);
            //         // for (j in 1..2 ^ (Length(ans)) - 1) {
            //         //     (ControlledOnInt(j, Z))(ans, aug);
            //         // }
            //         Controlled Z(ans, aug);
            //         ApplyToEachCA(X, qubits);
            //         ApplyToEachCA(H, qubits);
            //     }
            //     DumpRegister((), qubits);

            // // }
            // // let stateOracle = StateOracle(GroverStateAugmentedOracle(_, _, database));
            // // (AmpAmpByOracle(power, stateOracle, 0))(qubits);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    ///
    /// This allocates a qubit register that is structured as follows:
    /// The qubit register is composed of the stops, represented in bit form.
    /// Each stop is allocated the number of bits needed to represent the largest 
    /// index of the database.
    ///
    /// For example, if the database has three entries, each stop will be represented by 
    /// two qubits, and the qubit register will be six qubits long, because there are three stops
    /// represented by two qubits each.
    ///
    /// This is organized this way to represent both the stop number and sequence. If it were
    /// represented by a simple array, with each index representing the stop number in the solution,
    /// we would not know which stop is supposed to come in which order.
    ///
    operation CountSolutions(bitAccuracy: Int, maxError: Double, database: Database): Int {
        let numElements = Length(database!);
        let maxDbIndex = numElements - 1;
        let bitsForMaxDbIndex = BitSizeI(maxDbIndex);
        let lenT = bitAccuracy + CeilLogBase2(2.0 + 1.0 / (2.0 * maxError));
        Message($"t: {lenT}");

        mutable numSolutions = -1;
        using ((control, target) = (Qubit[lenT], Qubit[bitsForMaxDbIndex * numElements + 3])) {
            let controlBE = BigEndian(control);
            let ancilla = target[0];

            X(ancilla);
            ApplyToEachCA(H, control + target);
            for (i in 0..Length(control) - 1) {
                Controlled GroverPow([control[Length(control) - 1 - i]], (2 ^ i, target, database));
            }
            Adjoint QFT(controlBE);

            let fiBE = MeasureInteger(BigEndianAsLittleEndian(controlBE));
            let numSolutionsD = PowD(Sin(IntAsDouble(fiBE) / 2.0), 2.0) * IntAsDouble(2 ^ Length(control + target));

            Message("numSolutions: " + IntAsString(Round(numSolutionsD)));
            // let controlBE = BigEndian(control);
            // let EPR = target[0..1];
            // let ancilla = EPR[1];
            // let aug = Tail(target);
            // let ans = target[2..bitsForMaxDbIndex * numElements + 1];
            // let stateQubits = ans + [aug];
            // let inputQubits = [ancilla] +  stateQubits;
            // let discreteOracle = DiscreteOracle(GroverPow(_, _, database));

            // // GroverPow(2, target, database);
            // H(ancilla);
            // CNOT(ancilla, EPR[0]);

            // // ApplyToEachCA(H, control);
            // ApplyToEachCA(H, control + stateQubits);
            // for (i in 0..0) {
            //     Message(ToStringI(i));
            //     Controlled GroverPow([control[Length(control) - 1 - i]], (2 ^ i, inputQubits, database));
            // }
            // DumpRegister((), control);
            // Adjoint QFT(controlBE);

            // // ApplyToEachCA(H, target);
            // // QuantumPhaseEstimation(discreteOracle, target, controlBE);

            // let fiBE = QubitsToInt(control);
            // let fi = MeasureInteger(LittleEndian(control));
            // Message("fi: "+ ToStringI(fi));
            // Message("fiBE: "+ ToStringI(fiBE));

            // let numSolutionsD = PowD(Sin(ToDouble(fiBE) / 2.0), 2.0) * ToDouble(2 ^ Length(inputQubits));
            // Message("numSolutionsD: " + ToStringD(numSolutionsD));

            // // if (RealMod(numSolutionsD - 0.5, 1.0, 0.0) == 0.0) {
            // //     set numSolutions = Round(numSolutionsD - 0.5);
            // // } else {
            //     set numSolutions = Round(numSolutionsD);
            // // }

            ResetAll(control + target);
        }

        return numSolutions;
    }

    // operation Entry () : Unit {
    //     let numPickups = 3;
    //     let indicesLength = numPickups * BitSizeI(numPickups);
    //     using ((pickups, deliveries) = (Qubit[indicesLength], Qubit[indicesLength])) {

    //     }
    // }
}
