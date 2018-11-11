#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracleImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":93,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numElements\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracleImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":93,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numTests\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracleAugmentedImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":184,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numElements\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracleAugmentedImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":184,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":241,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numTests\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestOracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":241,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestApplyOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":256,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestApplyOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":256,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestCountSolutions\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":288,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"maxError\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestCountSolutions\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":288,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
#line hidden
namespace ShipmentsAssigner
{
    public class _TestGetQuantumIndexImpl : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestGetQuantumIndexImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "_TestGetQuantumIndexImpl";
        String ICallable.FullName => "ShipmentsAssigner._TestGetQuantumIndexImpl";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

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

        protected Allocate Allocate
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

        protected IUnitary<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)> GetElementUsingQuantumIndex
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsGeneralQubitsToInt
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qIndex,length) = __in;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var cIndex = UtilsGeneralQubitsToInt.Apply(qIndex?.Copy());
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var maxIndex = (2L.Pow(qIndex.Length) - 1L);
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var dbLength = (maxIndex + 1L);
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(String.Format("index: {0}", cIndex));
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var cDatabase = new QArray<Int64>(dbLength);
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            foreach (var i in new Range(0L, (dbLength - 1L)))
#line hidden
            {
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                cDatabase[i] = i;
            }

#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(String.Format("{0}", cDatabase));
#line hidden
            {
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var target = Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(dbLength));
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                GetElementUsingQuantumIndex.Apply((qIndex?.Copy(), cDatabase?.Copy(), new Microsoft.Quantum.Canon.BigEndian(target?.Copy())));
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var calcAns = UtilsGeneralQubitsToInt.Apply(target?.Copy());
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var trueAns = cDatabase[cIndex];
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, String.Format("{0} != {1}", calcAns, trueAns)));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(String.Format("{0} == {1}", calcAns, trueAns));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply("");
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                ResetAll.Apply(target?.Copy());
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GetElementUsingQuantumIndex = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(GetElementUsingQuantumIndex));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, Int64 length)
        {
            return __m__.Run<_TestGetQuantumIndexImpl, (QArray<Qubit>,Int64), QVoid>((qIndex, length));
        }
    }

    public class _TestGetQuantumIndex : Operation<Int64, QVoid>, ICallable
    {
        public _TestGetQuantumIndex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestGetQuantumIndex";
        String ICallable.FullName => "ShipmentsAssigner._TestGetQuantumIndex";
        protected ICallable<(QArray<Qubit>,Int64), QVoid> _TestGetQuantumIndexImpl
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
            var length = __in;
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply((length, _TestGetQuantumIndexImpl.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,Int64)>((_arg1) => (_arg1, length)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this._TestGetQuantumIndexImpl = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(_TestGetQuantumIndexImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<_TestGetQuantumIndex, Int64, QVoid>(length);
        }
    }

    public class _TestOracleImpl : Operation<(Database,Int64,QArray<Qubit>), QVoid>, ICallable
    {
        public _TestOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Database,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Database,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "_TestOracleImpl";
        String ICallable.FullName => "ShipmentsAssigner._TestOracleImpl";
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

        protected ICallable<Database, QArray<QArray<Int64>>> GetCategorizedEntries
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Database,Qubit)> Oracle
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

        public override Func<(Database,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (database,numElements,qubits) = __in;
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var qIndexLength = (qubits.Length / numElements);
#line hidden
            {
#line 114 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var ancillas = Allocate.Apply(1L);
#line 115 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var ancilla = ancillas[0L];
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Oracle.Apply((qubits?.Copy(), database, ancilla));
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var calcAns = M.Apply(ancilla);
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var cIndices = new QArray<Int64>(numElements);
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var startIndex = 0L;
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
                {
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var endIndex = ((startIndex + qIndexLength) - 1L);
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    cIndices[i] = UtilsGeneralQubitsToInt.Apply(qubits?.Slice(new Range(startIndex, endIndex)));
#line 127 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    startIndex = (endIndex + 1L);
                }

#line 130 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(UtilsGeneralIntArrrayToString.Apply(cIndices?.Copy()));
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var categorized = GetCategorizedEntries.Apply(database);
#line 133 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var times = categorized[1L];
#line 134 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var valid = true;
#line 135 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var lastTime = -(1L);
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (cIndices.Length - 1L)))
#line hidden
                {
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var cIndex = cIndices[i];
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    if ((cIndex < times.Length))
                    {
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        var time = times[cIndex];
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        if (((cIndex > 0L) && (time <= lastTime)))
                        {
#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                            valid = false;
                        }

#line 146 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        if ((cIndex > 0L))
                        {
#line 147 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                            lastTime = time;
                        }
                    }
                    else
                    {
#line 150 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        valid = false;
                    }
                }

#line 154 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var trueAns = MicrosoftQuantumCanonResultFromBool.Apply(valid);
#line 156 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumCanonAssertResultEqual.Apply((calcAns, trueAns, ("Incorrect. Correct answer is " + MicrosoftQuantumExtensionsConvertToStringB.Apply(valid))));
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(("Correctly " + MicrosoftQuantumExtensionsConvertToStringB.Apply(valid)));
#line 159 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
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
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.Oracle = this.Factory.Get<IUnitary<(QArray<Qubit>,Database,Qubit)>>(typeof(Oracle));
            this.UtilsGeneralIntArrrayToString = this.Factory.Get<ICallable<QArray<Int64>, String>>(typeof(Utils.General.IntArrrayToString));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((Database,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Database database, Int64 numElements, QArray<Qubit> qubits)
        {
            return __m__.Run<_TestOracleImpl, (Database,Int64,QArray<Qubit>), QVoid>((database, numElements, qubits));
        }
    }

    public class _TestOracle : Operation<Int64, QVoid>, ICallable
    {
        public _TestOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestOracle";
        String ICallable.FullName => "ShipmentsAssigner._TestOracle";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonIntegerIncrementLE
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
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

        protected ICallable<QVoid, Database> GetDatabase
        {
            get;
            set;
        }

        protected ICallable<(Database,Int64,QArray<Qubit>), QVoid> _TestOracleImpl
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
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var database = GetDatabase.Apply(QVoid.Instance);
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numElements = database.Data.Length;
#line 165 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var maxDbIndex = (numElements - 1L);
#line hidden
            {
#line 167 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var qubits = Allocate.Apply((MicrosoftQuantumCanonBitSize.Apply(maxDbIndex) * numElements));
#line 168 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumCanonIntegerIncrementLE.Apply((17L, new Microsoft.Quantum.Canon.LittleEndian(qubits?.Copy())));
#line 169 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(qubits?.Copy());
#line 170 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                _TestOracleImpl.Apply((database, numElements, qubits?.Copy()));
#line 171 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line 174 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply(((MicrosoftQuantumCanonBitSize.Apply(maxDbIndex) * numElements), _TestOracleImpl.Partial(new Func<QArray<Qubit>, (Database,Int64,QArray<Qubit>)>((_arg1) => (database, numElements, _arg1)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonIntegerIncrementLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementLE));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GetDatabase = this.Factory.Get<ICallable<QVoid, Database>>(typeof(GetDatabase));
            this._TestOracleImpl = this.Factory.Get<ICallable<(Database,Int64,QArray<Qubit>), QVoid>>(typeof(_TestOracleImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 numTests)
        {
            return __m__.Run<_TestOracle, Int64, QVoid>(numTests);
        }
    }

    public class _TestOracleAugmentedImpl : Operation<(Database,Int64,QArray<Qubit>), QVoid>, ICallable
    {
        public _TestOracleAugmentedImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Database,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Database,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "_TestOracleAugmentedImpl";
        String ICallable.FullName => "ShipmentsAssigner._TestOracleAugmentedImpl";
        protected ICallable<(Result,Result,String), QVoid> MicrosoftQuantumCanonAssertResultEqual
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultOne
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
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

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
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

        protected ICallable<Database, QArray<QArray<Int64>>> GetCategorizedEntries
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Database,Qubit,Qubit)> OracleAugmented
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

        public override Func<(Database,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (database,numElements,qubits) = __in;
#line 191 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var target = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 192 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var aug = MicrosoftQuantumCanonTail.Apply<Qubit>(qubits);
#line 193 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var qIndexLength = (qubits.Length / numElements);
#line hidden
            {
#line 195 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var ancillas = Allocate.Apply(1L);
#line 196 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var ancilla = ancillas[0L];
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                OracleAugmented.Apply((target?.Copy(), database, ancilla, aug));
#line 199 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var calcAns = M.Apply(ancilla);
#line 200 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var mAug = M.Apply(aug);
#line 202 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var cIndices = new QArray<Int64>(numElements);
#line 203 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var startIndex = 0L;
#line 204 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
                {
#line 205 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var endIndex = ((startIndex + qIndexLength) - 1L);
#line 206 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    cIndices[i] = UtilsGeneralQubitsToInt.Apply(target?.Slice(new Range(startIndex, endIndex)));
#line 207 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    startIndex = (endIndex + 1L);
                }

#line 210 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(((UtilsGeneralIntArrrayToString.Apply(cIndices?.Copy()) + ", aug: ") + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
                {mAug}))));
#line 212 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var categorized = GetCategorizedEntries.Apply(database);
#line 213 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var times = categorized[1L];
#line 214 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var valid = MicrosoftQuantumCanonIsResultOne.Apply(mAug);
#line 215 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var lastTime = -(1L);
#line 216 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (cIndices.Length - 1L)))
#line hidden
                {
#line 217 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var cIndex = cIndices[i];
#line 218 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    if ((cIndex < times.Length))
                    {
#line 219 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        var time = times[cIndex];
#line 221 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        if (((cIndex > 0L) && (time <= lastTime)))
                        {
#line 223 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                            valid = false;
                        }

#line 226 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        if ((cIndex > 0L))
                        {
#line 227 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                            lastTime = time;
                        }
                    }
                    else
                    {
#line 230 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        valid = false;
                    }
                }

#line 234 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var trueAns = MicrosoftQuantumCanonResultFromBool.Apply(valid);
#line 236 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumCanonAssertResultEqual.Apply((calcAns, trueAns, ("Incorrect. Correct answer is " + MicrosoftQuantumExtensionsConvertToStringB.Apply(valid))));
#line 237 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(("Correctly " + MicrosoftQuantumExtensionsConvertToStringB.Apply(valid)));
#line 239 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
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
            this.MicrosoftQuantumCanonIsResultOne = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.IsResultOne));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringB = this.Factory.Get<ICallable<Boolean, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringB));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.OracleAugmented = this.Factory.Get<IUnitary<(QArray<Qubit>,Database,Qubit,Qubit)>>(typeof(OracleAugmented));
            this.UtilsGeneralIntArrrayToString = this.Factory.Get<ICallable<QArray<Int64>, String>>(typeof(Utils.General.IntArrrayToString));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((Database,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Database database, Int64 numElements, QArray<Qubit> qubits)
        {
            return __m__.Run<_TestOracleAugmentedImpl, (Database,Int64,QArray<Qubit>), QVoid>((database, numElements, qubits));
        }
    }

    public class _TestOracleAugmented : Operation<Int64, QVoid>, ICallable
    {
        public _TestOracleAugmented(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestOracleAugmented";
        String ICallable.FullName => "ShipmentsAssigner._TestOracleAugmented";
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

        protected ICallable<QVoid, Database> GetDatabase
        {
            get;
            set;
        }

        protected ICallable<(Database,Int64,QArray<Qubit>), QVoid> _TestOracleAugmentedImpl
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
#line 243 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var database = GetDatabase.Apply(QVoid.Instance);
#line 244 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numElements = database.Data.Length;
#line 245 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var maxDbIndex = (numElements - 1L);
#line 254 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply((((MicrosoftQuantumCanonBitSize.Apply(maxDbIndex) * numElements) + 1L), _TestOracleAugmentedImpl.Partial(new Func<QArray<Qubit>, (Database,Int64,QArray<Qubit>)>((_arg1) => (database, numElements, _arg1)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetDatabase = this.Factory.Get<ICallable<QVoid, Database>>(typeof(GetDatabase));
            this._TestOracleAugmentedImpl = this.Factory.Get<ICallable<(Database,Int64,QArray<Qubit>), QVoid>>(typeof(_TestOracleAugmentedImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 numTests)
        {
            return __m__.Run<_TestOracleAugmented, Int64, QVoid>(numTests);
        }
    }

    public class _TestApplyOracle : Operation<QVoid, QVoid>, ICallable
    {
        public _TestApplyOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestApplyOracle";
        String ICallable.FullName => "ShipmentsAssigner._TestApplyOracle";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<QVoid, Database> GetDatabase
        {
            get;
            set;
        }

        protected IUnitary<(Int64,QArray<Qubit>,Database)> OraclePow
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 258 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var database = GetDatabase.Apply(QVoid.Instance);
#line 259 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numElements = database.Data.Length;
#line 260 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var maxDbIndex = (numElements - 1L);
#line 261 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var bitsForMaxDbIndex = MicrosoftQuantumCanonBitSize.Apply(maxDbIndex);
#line hidden
            {
#line 263 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var target = Allocate.Apply(((bitsForMaxDbIndex * numElements) + 2L));
#line 264 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var ancilla = target[0L];
#line 265 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var aug = MicrosoftQuantumCanonTail.Apply<Qubit>(target);
#line 266 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var ans = target?.Slice(new Range(1L, (bitsForMaxDbIndex * numElements)));
#line 267 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var discreteOracle = new Microsoft.Quantum.Canon.DiscreteOracle(OraclePow.Partial(new Func<(Int64,QArray<Qubit>), (Int64,QArray<Qubit>,Database)>((_arg1) => (_arg1.Item1, _arg1.Item2, database))));
#line 269 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumCanonQFT.Apply(new Microsoft.Quantum.Canon.BigEndian((new QArray<Qubit>()
                {aug} + ans)));
#line 270 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumPrimitiveX.Apply(ancilla);
#line 271 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                MicrosoftQuantumPrimitiveH.Apply(ancilla);
#line 272 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                discreteOracle.Data.Apply((1L, target?.Copy()));
#line 275 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var calcAnsStr = "";
#line 276 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
                {
#line 277 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var startIndex = (i * bitsForMaxDbIndex);
#line 278 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var endIndex = ((startIndex + bitsForMaxDbIndex) - 1L);
#line 280 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    calcAnsStr = (calcAnsStr + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(ans?.Slice(new Range(startIndex, endIndex))))));
                }

#line 283 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(("calcAns: " + calcAnsStr));
#line 285 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                ResetAll.Apply(target?.Copy());
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.GetDatabase = this.Factory.Get<ICallable<QVoid, Database>>(typeof(GetDatabase));
            this.OraclePow = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>,Database)>>(typeof(OraclePow));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<_TestApplyOracle, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class _TestCountSolutions : Operation<Double, QVoid>, ICallable
    {
        public _TestCountSolutions(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestCountSolutions";
        String ICallable.FullName => "ShipmentsAssigner._TestCountSolutions";
        protected ICallable<(Double,Database), QVoid> CountSolutions
        {
            get;
            set;
        }

        protected ICallable<QVoid, Database> GetDatabase
        {
            get;
            set;
        }

        public override Func<Double, QVoid> Body => (__in) =>
        {
            var maxError = __in;
#line 290 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            CountSolutions.Apply((maxError, GetDatabase.Apply(QVoid.Instance)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.CountSolutions = this.Factory.Get<ICallable<(Double,Database), QVoid>>(typeof(CountSolutions));
            this.GetDatabase = this.Factory.Get<ICallable<QVoid, Database>>(typeof(GetDatabase));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double maxError)
        {
            return __m__.Run<_TestCountSolutions, Double, QVoid>(maxError);
        }
    }
}