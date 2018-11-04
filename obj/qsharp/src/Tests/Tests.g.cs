#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests\",\"Name\":\"_OracleTestImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numElements\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Tests\",\"Name\":\"_OracleTestImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests\",\"Name\":\"OracleTest\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numTests\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Tests\",\"Name\":\"OracleTest\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace Tests
{
    public class _OracleTestImpl : Operation<(ShipmentsAssigner.Database,Int64,QArray<Qubit>), QVoid>, ICallable
    {
        public _OracleTestImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ShipmentsAssigner.Database,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((ShipmentsAssigner.Database,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "_OracleTestImpl";
        String ICallable.FullName => "Tests._OracleTestImpl";
        protected ICallable<(Result,Result,String), QVoid> MicrosoftQuantumCanonAssertResultEqual
        {
            get;
            set;
        }

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Boolean, String> MicrosoftQuantumExtensionsConvertToStringB
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<ShipmentsAssigner.Database, QArray<QArray<Int64>>> ShipmentsAssignerGetCategorizedEntries
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,ShipmentsAssigner.Database,Qubit), QVoid> ShipmentsAssignerOracle
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, String> UtilsGeneralIntArrrayToString
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsGeneralQubitsToInt
        {
            get;
            set;
        }

        public override Func<(ShipmentsAssigner.Database,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (database,numElements,qubits) = __in;
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
            var qIndexLength = (qubits.Length / numElements);
#line hidden
            {
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var ancillas = Allocate.Apply(1L);
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var ancilla = ancillas[0L];
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                ShipmentsAssignerOracle.Apply((qubits?.Copy(), database, ancilla));
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var calcAns = M.Apply(ancilla);
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var cIndices = new QArray<Int64>(numElements);
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var startIndex = 0L;
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
                {
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                    var endIndex = ((startIndex + qIndexLength) - 1L);
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                    cIndices[i] = UtilsGeneralQubitsToInt.Apply(qubits?.Slice(new Range(startIndex, endIndex)));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                    startIndex = (endIndex + 1L);
                }

#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                Message.Apply(UtilsGeneralIntArrrayToString.Apply(cIndices?.Copy()));
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var categorized = ShipmentsAssignerGetCategorizedEntries.Apply(database);
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var times = categorized[1L];
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var valid = true;
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var lastTime = -(1L);
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                foreach (var i in new Range(0L, (cIndices.Length - 1L)))
#line hidden
                {
#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                    var cIndex = cIndices[i];
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                    if ((cIndex < times.Length))
                    {
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                        var time = times[cIndex];
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                        if (((time > 0L) && (time <= lastTime)))
                        {
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                            valid = false;
                        }

#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                        lastTime = time;
                    }
                }

#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                var trueAns = MicrosoftQuantumCanonResultFromBool.Apply(valid);
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                MicrosoftQuantumCanonAssertResultEqual.Apply((calcAns, trueAns, ("Incorrect. Correct answer is " + MicrosoftQuantumExtensionsConvertToStringB.Apply(valid))));
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
                ResetAll.Apply(ancillas?.Copy());
#line hidden
                Release.Apply(ancillas);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertResultEqual = this.Factory.Get<ICallable<(Result,Result,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertResultEqual));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringB = this.Factory.Get<ICallable<Boolean, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringB));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.ShipmentsAssignerGetCategorizedEntries = this.Factory.Get<ICallable<ShipmentsAssigner.Database, QArray<QArray<Int64>>>>(typeof(ShipmentsAssigner.GetCategorizedEntries));
            this.ShipmentsAssignerOracle = this.Factory.Get<ICallable<(QArray<Qubit>,ShipmentsAssigner.Database,Qubit), QVoid>>(typeof(ShipmentsAssigner.Oracle));
            this.UtilsGeneralIntArrrayToString = this.Factory.Get<ICallable<QArray<Int64>, String>>(typeof(Utils.General.IntArrrayToString));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((ShipmentsAssigner.Database,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ShipmentsAssigner.Database database, Int64 numElements, QArray<Qubit> qubits)
        {
            return __m__.Run<_OracleTestImpl, (ShipmentsAssigner.Database,Int64,QArray<Qubit>), QVoid>((database, numElements, qubits));
        }
    }

    public class OracleTest : Operation<Int64, QVoid>, ICallable
    {
        public OracleTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "OracleTest";
        String ICallable.FullName => "Tests.OracleTest";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<QVoid, ShipmentsAssigner.Database> ShipmentsAssignerGetDatabase
        {
            get;
            set;
        }

        protected ICallable<(ShipmentsAssigner.Database,Int64,QArray<Qubit>), QVoid> _OracleTestImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), QVoid> UtilsTestingRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var numTests = __in;
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
            var database = ShipmentsAssignerGetDatabase.Apply(QVoid.Instance);
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
            var numElements = database.Data.Length;
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
            var maxDbIndex = (numElements - 1L);
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Tests/Tests.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply(((MicrosoftQuantumCanonBitSize.Apply(maxDbIndex) * numElements), _OracleTestImpl.Partial(new Func<QArray<Qubit>, (ShipmentsAssigner.Database,Int64,QArray<Qubit>)>((_arg1) => (database, numElements, _arg1)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.ShipmentsAssignerGetDatabase = this.Factory.Get<ICallable<QVoid, ShipmentsAssigner.Database>>(typeof(ShipmentsAssigner.GetDatabase));
            this._OracleTestImpl = this.Factory.Get<ICallable<(ShipmentsAssigner.Database,Int64,QArray<Qubit>), QVoid>>(typeof(_OracleTestImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 numTests)
        {
            return __m__.Run<OracleTest, Int64, QVoid>(numTests);
        }
    }
}