#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStopImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStopImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStopsInSpecifiedOrderImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"elementLength\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":79}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":87}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStopsInSpecifiedOrderImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStopsInSpecifiedOrder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestLoadStopsInSpecifiedOrder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
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

        protected IUnitary<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)> GetElementUsingQuantumIndex
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
                GetElementUsingQuantumIndex.Apply((qIndex?.Copy(), cDatabase?.Copy(), target?.Copy()));
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
            this.GetElementUsingQuantumIndex = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)>>(typeof(GetElementUsingQuantumIndex));
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

    public class _TestLoadStopImpl : Operation<(Database,QArray<Qubit>), QVoid>, ICallable
    {
        public _TestLoadStopImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Database,QArray<Qubit>)>, IApplyData
        {
            public In((Database,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "_TestLoadStopImpl";
        String ICallable.FullName => "ShipmentsAssigner._TestLoadStopImpl";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
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

        protected IUnitary<QArray<Qubit>> MicrosoftQuantumExtensionsTestingAssertAllZero
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

        protected ICallable<DatabaseEntry, QArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Database,QArray<Qubit>), QVoid> LoadStop
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsGeneralQubitsToInt
        {
            get;
            set;
        }

        public override Func<(Database,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (database,qIndex) = __in;
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var cIndex = UtilsGeneralQubitsToInt.Apply(qIndex?.Copy());
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numStops = database.Data.Length;
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var nullStop = (cIndex >= numStops);
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var propertyLengths = GetPropertyLengths.Apply(database);
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numProperties = propertyLengths.Length;
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(("qIndex length: " + MicrosoftQuantumExtensionsConvertToStringI.Apply(qIndex.Length)));
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(("Index: " + MicrosoftQuantumExtensionsConvertToStringI.Apply(cIndex)));
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(String.Format("num stops: {0}", numStops));
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var targetLength = 0L;
#line 57 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            foreach (var i in new Range(0L, (numProperties - 1L)))
#line hidden
            {
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                targetLength = (targetLength + propertyLengths[i]);
            }

#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(String.Format("target length: {0}", targetLength));
#line hidden
            {
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var target = Allocate.Apply(targetLength);
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                LoadStop.Apply((qIndex?.Copy(), database, target?.Copy()));
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                if (nullStop)
                {
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(target?.Copy());
                }
                else
                {
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var trueStop = database.Data[cIndex];
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var stopArray = DatabaseEntryToArray.Apply(trueStop);
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var startIndex = 0L;
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    foreach (var i in new Range(0L, (stopArray.Length - 1L)))
#line hidden
                    {
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        Message.Apply(String.Format("Category: {0}", i));
#line 75 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        var endIndex = ((startIndex + propertyLengths[i]) - 1L);
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        var calcAns = UtilsGeneralQubitsToInt.Apply(target?.Slice(new Range(startIndex, endIndex)));
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        var trueAns = stopArray[i];
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, String.Format("{0} != {1}", calcAns, trueAns)));
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                        startIndex = (endIndex + 1L);
                    }
                }

#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
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
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, QArray<Int64>>>(typeof(DatabaseEntryToArray));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this.LoadStop = this.Factory.Get<ICallable<(QArray<Qubit>,Database,QArray<Qubit>), QVoid>>(typeof(LoadStop));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((Database,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Database database, QArray<Qubit> qIndex)
        {
            return __m__.Run<_TestLoadStopImpl, (Database,QArray<Qubit>), QVoid>((database, qIndex));
        }
    }

    public class _TestLoadStop : Operation<QVoid, QVoid>, ICallable
    {
        public _TestLoadStop(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestLoadStop";
        String ICallable.FullName => "ShipmentsAssigner._TestLoadStop";
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

        protected ICallable<(Database,QArray<Qubit>), QVoid> _TestLoadStopImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), QVoid> UtilsTestingRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var database = GetDatabase.Apply(QVoid.Instance);
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numElements = database.Data.Length;
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var maxDbIndex = (numElements - 1L);
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply((MicrosoftQuantumCanonBitSize.Apply(maxDbIndex), _TestLoadStopImpl.Partial(new Func<QArray<Qubit>, (Database,QArray<Qubit>)>((_arg1) => (GetDatabase.Apply(QVoid.Instance), _arg1)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetDatabase = this.Factory.Get<ICallable<QVoid, Database>>(typeof(GetDatabase));
            this._TestLoadStopImpl = this.Factory.Get<ICallable<(Database,QArray<Qubit>), QVoid>>(typeof(_TestLoadStopImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<_TestLoadStop, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class _TestLoadStopsInSpecifiedOrderImpl : Operation<(Database,Int64,QArray<Qubit>), QVoid>, ICallable
    {
        public _TestLoadStopsInSpecifiedOrderImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Database,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Database,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "_TestLoadStopsInSpecifiedOrderImpl";
        String ICallable.FullName => "ShipmentsAssigner._TestLoadStopsInSpecifiedOrderImpl";
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

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>), QVoid> LoadStopsInSpecifiedOrder
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
            var (database,elementLength,a) = __in;
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var lenA = a.Length;
#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numCategories = GetCategorizedEntries.Apply(database).Length;
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numElements = database.Data.Length;
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var lenIndex = (lenA / numElements);
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            Message.Apply(String.Format("lenA: {0}; numCategories: {1}; numElements: {2}; lenIndex: {3}", lenA, numCategories, numElements, lenIndex));
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var qIndices = new QArray<QArray<Qubit>>(numElements);
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
            {
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var startIndex = (i * lenIndex);
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var endIndex = ((startIndex + lenIndex) - 1L);
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                qIndices[i] = a?.Slice(new Range(startIndex, endIndex));
            }

#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var targetQubitsNeeded = (numElements * elementLength);
#line 113 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var lenTarget = (targetQubitsNeeded / numElements);
#line hidden
            {
#line 115 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var targetQubits = Allocate.Apply(targetQubitsNeeded);
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var targets = new QArray<QArray<Qubit>>(numElements);
#line 117 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
                {
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var startIndex = (i * lenTarget);
#line 119 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    var endIndex = ((startIndex + lenTarget) - 1L);
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    targets[i] = targetQubits?.Slice(new Range(startIndex, endIndex));
                }

#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                var indexOrder = "";
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
                {
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                    indexOrder = (indexOrder + MicrosoftQuantumExtensionsConvertToStringI.Apply(UtilsGeneralQubitsToInt.Apply(qIndices[i])));
                }

#line 127 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                Message.Apply(String.Format("Index order: {0}", indexOrder));
#line 129 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                LoadStopsInSpecifiedOrder.Apply((qIndices?.Copy(), database, targets?.Copy()));
#line 131 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                ResetAll.Apply(targetQubits?.Copy());
#line hidden
                Release.Apply(targetQubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this.LoadStopsInSpecifiedOrder = this.Factory.Get<ICallable<(QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>), QVoid>>(typeof(LoadStopsInSpecifiedOrder));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((Database,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Database database, Int64 elementLength, QArray<Qubit> a)
        {
            return __m__.Run<_TestLoadStopsInSpecifiedOrderImpl, (Database,Int64,QArray<Qubit>), QVoid>((database, elementLength, a));
        }
    }

    public class _TestLoadStopsInSpecifiedOrder : Operation<QVoid, QVoid>, ICallable
    {
        public _TestLoadStopsInSpecifiedOrder(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestLoadStopsInSpecifiedOrder";
        String ICallable.FullName => "ShipmentsAssigner._TestLoadStopsInSpecifiedOrder";
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

        protected ICallable<Database, QArray<QArray<Int64>>> GetCategorizedEntries
        {
            get;
            set;
        }

        protected ICallable<QVoid, Database> GetDatabase
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected ICallable<(Database,Int64,QArray<Qubit>), QVoid> _TestLoadStopsInSpecifiedOrderImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), QVoid> UtilsTestingRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 135 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var database = GetDatabase.Apply(QVoid.Instance);
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numCategories = GetCategorizedEntries.Apply(database).Length;
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var numElements = database.Data.Length;
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var totalElementLength = 0L;
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            foreach (var i in new Range(0L, (numElements - 1L)))
#line hidden
            {
#line 142 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
                totalElementLength = (totalElementLength + elementLengths[i]);
            }

#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            var totalIndiceQubitsNeeded = (MicrosoftQuantumCanonBitSize.Apply(numElements) * numElements);
#line 147 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Testing.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply((totalIndiceQubitsNeeded, _TestLoadStopsInSpecifiedOrderImpl.Partial(new Func<QArray<Qubit>, (Database,Int64,QArray<Qubit>)>((_arg1) => (database, totalElementLength, _arg1)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.GetDatabase = this.Factory.Get<ICallable<QVoid, Database>>(typeof(GetDatabase));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this._TestLoadStopsInSpecifiedOrderImpl = this.Factory.Get<ICallable<(Database,Int64,QArray<Qubit>), QVoid>>(typeof(_TestLoadStopsInSpecifiedOrderImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<_TestLoadStopsInSpecifiedOrder, QVoid, QVoid>(QVoid.Instance);
        }
    }
}