#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"TimesAreValid\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nodes\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"TimesAreValid\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"endIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":59,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":60,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_GetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":78}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_GetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":65,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_GetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":84,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":74}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"depth\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":85},\"Item2\":{\"Line\":1,\"Column\":90}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndexImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_TestGetQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
#line hidden
namespace ShipmentsAssigner
{
    public class NodeRegisterLengths : UDTBase<(Int64,Int64,Int64,Int64)>, IApplyData
    {
        public NodeRegisterLengths() : base(default((Int64,Int64,Int64,Int64)))
        {
        }

        public NodeRegisterLengths((Int64,Int64,Int64,Int64) data) : base(data)
        {
        }

        public Int64 Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        public Int64 Item3 => Data.Item3;
        public Int64 Item4 => Data.Item4;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Int64 item1, out Int64 item2, out Int64 item3, out Int64 item4)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
            item4 = Data.Item4;
        }

        public static UDTPartial<P, (Int64,Int64,Int64,Int64), NodeRegisterLengths> Partial<P>(Func<P, (Int64,Int64,Int64,Int64)> mapper) => new UDTPartial<P, (Int64,Int64,Int64,Int64), NodeRegisterLengths>(mapper);
    }

    public class Node : UDTBase<(QArray<Qubit>,Int64,Int64,Int64)>, IApplyData
    {
        public Node() : base(default((QArray<Qubit>,Int64,Int64,Int64)))
        {
        }

        public Node((QArray<Qubit>,Int64,Int64,Int64) data) : base(data)
        {
        }

        public QArray<Qubit> Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        public Int64 Item3 => Data.Item3;
        public Int64 Item4 => Data.Item4;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        public void Deconstruct(out QArray<Qubit> item1, out Int64 item2, out Int64 item3, out Int64 item4)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
            item4 = Data.Item4;
        }

        public static UDTPartial<P, (QArray<Qubit>,Int64,Int64,Int64), Node> Partial<P>(Func<P, (QArray<Qubit>,Int64,Int64,Int64)> mapper) => new UDTPartial<P, (QArray<Qubit>,Int64,Int64,Int64), Node>(mapper);
    }

    public class TimesAreValid : Operation<(QArray<Node>,Qubit), QVoid>, ICallable
    {
        public TimesAreValid(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Node>,Qubit)>, IApplyData
        {
            public In((QArray<Node>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "TimesAreValid";
        String ICallable.FullName => "ShipmentsAssigner.TimesAreValid";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Int64)> UtilsMathQFTAdderInt
        {
            get;
            set;
        }

        public override Func<(QArray<Node>,Qubit), QVoid> Body => (__in) =>
        {
            var (nodes,target) = __in;
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numNodes = nodes.Length;
#line hidden
            {
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var control = Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numNodes));
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(MicrosoftQuantumCanonTail.Apply<Qubit>(control));
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var lastTime = -(1L);
#line 22 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var node in nodes)
#line hidden
                {
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var (nodeId,shipmentId,time,coordinates) = node.Data;
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    if ((lastTime <= time))
                    {
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        UtilsMathQFTAdderInt.Apply((control?.Copy(), -(1L)));
                    }

#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, control?.Copy()));
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((control?.Copy(), target));
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, control?.Copy()));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    lastTime = time;
                }

#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                lastTime = -(1L);
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var node in nodes)
#line hidden
                {
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var (nodeId,shipmentId,time,coordinates) = node.Data;
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    if ((lastTime <= time))
                    {
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        UtilsMathQFTAdderInt.Apply((control?.Copy(), 1L));
                    }

#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    lastTime = time;
                }

#line hidden
                Release.Apply(control);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.UtilsMathQFTAdderInt = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64)>>(typeof(Utils.Math.QFTAdderInt));
        }

        public override IApplyData __dataIn((QArray<Node>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Node> nodes, Qubit target)
        {
            return __m__.Run<TimesAreValid, (QArray<Node>,Qubit), QVoid>((nodes, target));
        }
    }

    public class Slice : Unitary<(QArray<Qubit>,Int64,Int64,QArray<Qubit>)>, ICallable
    {
        public Slice(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "Slice";
        String ICallable.FullName => "ShipmentsAssigner.Slice";
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

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (arr,startIndex,endIndex,target) = __in;
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var targetLength = target.Length;
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var sliceLength = ((endIndex - startIndex) + 1L);
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((target.Length, ((endIndex - startIndex) + 1L), String.Format("target not correct length; targetLength: {0}, sliceLength: {1}", targetLength, sliceLength)));
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var slicedArr = arr?.Slice(new Range(startIndex, endIndex));
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (slicedArr.Length - 1L)))
#line hidden
            {
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((slicedArr[i], target[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (arr,startIndex,endIndex,target) = __in;
#line hidden
            var targetLength = target.Length;
#line hidden
            var sliceLength = ((endIndex - startIndex) + 1L);
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply((target.Length, ((endIndex - startIndex) + 1L), String.Format("target not correct length; targetLength: {0}, sliceLength: {1}", targetLength, sliceLength)));
#line hidden
            var slicedArr = arr?.Slice(new Range(startIndex, endIndex));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (slicedArr.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((slicedArr[i], target[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(arr,startIndex,endIndex,target)) = __in;
#line hidden
            var targetLength = target.Length;
#line hidden
            var sliceLength = ((endIndex - startIndex) + 1L);
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply((target.Length, ((endIndex - startIndex) + 1L), String.Format("target not correct length; targetLength: {0}, sliceLength: {1}", targetLength, sliceLength)));
#line hidden
            var slicedArr = arr?.Slice(new Range(startIndex, endIndex));
#line hidden
            foreach (var i in new Range(0L, (slicedArr.Length - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (slicedArr[i], target[i])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(arr,startIndex,endIndex,target)) = __in;
#line hidden
            var targetLength = target.Length;
#line hidden
            var sliceLength = ((endIndex - startIndex) + 1L);
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply((target.Length, ((endIndex - startIndex) + 1L), String.Format("target not correct length; targetLength: {0}, sliceLength: {1}", targetLength, sliceLength)));
#line hidden
            var slicedArr = arr?.Slice(new Range(startIndex, endIndex));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (slicedArr.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (slicedArr[i], target[i])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> arr, Int64 startIndex, Int64 endIndex, QArray<Qubit> target)
        {
            return __m__.Run<Slice, (QArray<Qubit>,Int64,Int64,QArray<Qubit>), QVoid>((arr, startIndex, endIndex, target));
        }
    }

    public class _GetQuantumIndexImpl : Adjointable<(Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)>, ICallable
    {
        public _GetQuantumIndexImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2?.Data)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "_GetQuantumIndexImpl";
        String ICallable.FullName => "ShipmentsAssigner._GetQuantumIndexImpl";
        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Int64,Int64,QArray<Qubit>)> Slice
        {
            get;
            set;
        }

        public override Func<(Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (control,database,qubits) = __in;
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var windowSize = database.Data.Length;
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var halfWindowSize = (windowSize / 2L);
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var isEven = ((windowSize % 2L) == 0L);
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var sliceFunc = Slice.Partial(new Func<(Int64,Int64,QArray<Qubit>), (QArray<Qubit>,Int64,Int64,QArray<Qubit>)>((_arg1) => (database.Data, _arg1.Item1, _arg1.Item2, _arg1.Item3)));
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var sliceLower = sliceFunc.Controlled.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (QArray<Qubit>,(Int64,Int64,QArray<Qubit>))>((_arg2) => (_arg2.Item1, (0L, (halfWindowSize - 1L), _arg2.Item2))));
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var sliceUpper = sliceFunc.Controlled.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (QArray<Qubit>,(Int64,Int64,QArray<Qubit>))>((_arg3) => (_arg3.Item1, (halfWindowSize, (windowSize - 1L), _arg3.Item2))));
#line 75 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            sliceLower.Apply((new QArray<Qubit>()
            {control}, MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits)));
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumPrimitiveX.Apply(control);
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            if (isEven)
            {
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                sliceUpper.Apply((new QArray<Qubit>()
                {control}, MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits)));
            }
            else
            {
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                sliceUpper.Apply((new QArray<Qubit>()
                {control}, qubits?.Copy()));
            }

#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumPrimitiveX.Apply(control);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (control,database,qubits) = __in;
#line hidden
            var windowSize = database.Data.Length;
#line hidden
            var halfWindowSize = (windowSize / 2L);
#line hidden
            var isEven = ((windowSize % 2L) == 0L);
#line hidden
            var sliceFunc = Slice.Partial(new Func<(Int64,Int64,QArray<Qubit>), (QArray<Qubit>,Int64,Int64,QArray<Qubit>)>((_arg1) => (database.Data, _arg1.Item1, _arg1.Item2, _arg1.Item3)));
#line hidden
            var sliceLower = sliceFunc.Controlled.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (QArray<Qubit>,(Int64,Int64,QArray<Qubit>))>((_arg2) => (_arg2.Item1, (0L, (halfWindowSize - 1L), _arg2.Item2))));
#line hidden
            var sliceUpper = sliceFunc.Controlled.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (QArray<Qubit>,(Int64,Int64,QArray<Qubit>))>((_arg3) => (_arg3.Item1, (halfWindowSize, (windowSize - 1L), _arg3.Item2))));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
#line hidden
            if (isEven)
            {
#line hidden
                sliceUpper.Adjoint.Apply((new QArray<Qubit>()
                {control}, MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits)));
            }
            else
            {
#line hidden
                sliceUpper.Adjoint.Apply((new QArray<Qubit>()
                {control}, qubits?.Copy()));
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
#line hidden
            sliceLower.Adjoint.Apply((new QArray<Qubit>()
            {control}, MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Slice = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64,Int64,QArray<Qubit>)>>(typeof(Slice));
        }

        public override IApplyData __dataIn((Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit control, Microsoft.Quantum.Canon.LittleEndian database, QArray<Qubit> qubits)
        {
            return __m__.Run<_GetQuantumIndexImpl, (Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>), QVoid>((control, database, qubits));
        }
    }

    public class GetQuantumIndex : Operation<(QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public GetQuantumIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2?.Data)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GetQuantumIndex";
        String ICallable.FullName => "ShipmentsAssigner.GetQuantumIndex";
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        protected IAdjointable<(Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)> _GetQuantumIndexImpl
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qIndex,database,target,depth) = __in;
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            Message.Apply(String.Format("depth: {0}", depth));
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            if ((qIndex.Length == depth))
            {
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((database.Data[0L], target[0L]));
            }
            else
            {
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var windowSize = database.Data.Length;
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var halfWindowSize = (windowSize / 2L);
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var isEven = ((windowSize % 2L) == 0L);
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var control = qIndex[depth];
#line hidden
                {
#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var qubits = Allocate.Apply((halfWindowSize + 1L));
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var qubitsLength = qubits.Length;
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    Message.Apply(String.Format("qubits length: {0}", qubitsLength));
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    _GetQuantumIndexImpl.Apply((control, database, qubits?.Copy()));
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    ((ICallable)this).Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(qubits?.Copy()), target?.Copy(), (depth + 1L)));
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    _GetQuantumIndexImpl.Adjoint.Apply((control, database, qubits?.Copy()));
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this._GetQuantumIndexImpl = this.Factory.Get<IAdjointable<(Qubit,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)>>(typeof(_GetQuantumIndexImpl));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, Microsoft.Quantum.Canon.LittleEndian database, QArray<Qubit> target, Int64 depth)
        {
            return __m__.Run<GetQuantumIndex, (QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64), QVoid>((qIndex, database, target, depth));
        }
    }

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

        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
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

        protected ICallable<(QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64), QVoid> GetQuantumIndex
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsGeneralQubitsToInt
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Int64>)> UtilsGeneralSetQubits
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qIndex,length) = __in;
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var cIndex = UtilsGeneralQubitsToInt.Apply(qIndex?.Copy());
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var maxIndex = (2L.Pow(qIndex.Length) - 1L);
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            Message.Apply(String.Format("index: {0}", cIndex));
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var cDatabase = new QArray<Int64>(maxIndex);
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseStr = "";
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (maxIndex - 1L)))
#line hidden
            {
#line 127 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                cDatabase[i] = MicrosoftQuantumCanonRandomInt.Apply(2L);
#line 128 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                databaseStr = (databaseStr + MicrosoftQuantumExtensionsConvertToStringI.Apply(cDatabase[i]));
            }

#line 130 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            Message.Apply(String.Format("database: {0}", databaseStr));
#line hidden
            {
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var (qDatabase,target) = (Allocate.Apply(maxIndex), Allocate.Apply(1L));
#line 133 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                UtilsGeneralSetQubits.Apply((qDatabase?.Copy(), cDatabase?.Copy()));
#line 135 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                GetQuantumIndex.Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(qDatabase?.Copy()), target?.Copy(), 0L));
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var calcAns = UtilsGeneralQubitsToInt.Apply(target?.Copy());
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var trueAns = cDatabase[cIndex];
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, String.Format("{0} != {1}", calcAns, trueAns)));
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                Message.Apply(String.Format("{0} == {1}", calcAns, trueAns));
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                Message.Apply("");
#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                ResetAll.Apply((qDatabase + target));
#line hidden
                Release.Apply(qDatabase);
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
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GetQuantumIndex = this.Factory.Get<ICallable<(QArray<Qubit>,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>,Int64), QVoid>>(typeof(GetQuantumIndex));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
            this.UtilsGeneralSetQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>)>>(typeof(Utils.General.SetQubits));
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

        protected ICallable<(Int64,ICallable), QVoid> UtilsGeneralRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var length = __in;
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            UtilsGeneralRunOnAllBinariesOfLength.Apply((length, _TestGetQuantumIndexImpl.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,Int64)>((_arg1) => (_arg1, length)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this._TestGetQuantumIndexImpl = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(_TestGetQuantumIndexImpl));
            this.UtilsGeneralRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.General.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<_TestGetQuantumIndex, Int64, QVoid>(length);
        }
    }
}