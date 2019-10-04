#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item1__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item2__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item3__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Null\"}}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"TypeItems\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item1__\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Null\"}}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Null\"}}]}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Null\"}}]}]},\"TypeItems\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":33}}]}}]}]}]}]}]]},\"Documentation\":[]}")]
[assembly: TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"TypeItems\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item1__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item2__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item3__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item4__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\",\"Range\":{\"Case\":\"Null\"}}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"TypeItems\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Anonymous\",\"Fields\":[{\"Case\":\"Int\"}]}]}]]},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item1__\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item2__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item3__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__Item4__\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\",\"Range\":{\"Case\":\"Null\"}}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetTimeIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetTimeIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"BigEndian\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":85}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":74}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"BigEndian\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":27,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":46,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":47,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":59}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":50}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":47}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":59}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"BigEndian\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":78}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"propertyIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"BigEndian\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":86,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":95,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":97,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":3,\"Column\":26},\"Item2\":{\"Line\":3,\"Column\":34}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lastTime\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"BigEndian\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":4,\"Column\":26},\"Item2\":{\"Line\":4,\"Column\":35}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"isInvalidLE\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"LittleEndian\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":5,\"Column\":26},\"Item2\":{\"Line\":5,\"Column\":38}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"BigEndian\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Arithmetic\",\"Name\":\"LittleEndian\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":144,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":193,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":194,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":195,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CreateIndices\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":290,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numStops\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lenIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numProperties\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"propertyLengths\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":6,\"Column\":13},\"Item2\":{\"Line\":6,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CreateIndices\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":290,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":309,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":3,\"Column\":23},\"Item2\":{\"Line\":3,\"Column\":31}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":315,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":341,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":342,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":343,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":346,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":3,\"Column\":23},\"Item2\":{\"Line\":3,\"Column\":31}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aug\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":353,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":381,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":382,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":383,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverStateAugmentedOracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":386,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"flagIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":89}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":79}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverStateAugmentedOracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":387,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverStateAugmentedOracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":395,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverStateAugmentedOracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":396,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverStateAugmentedOracle\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":397,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverPow\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":400,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":68}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverPow\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":401,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverPow\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":442,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverPow\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":443,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GroverPow\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":444,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CountSolutions\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":447,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bitAccuracy\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"maxError\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":80}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Double\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CountSolutions\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":447,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace ShipmentsAssigner
{
    public class DatabaseEntry : UDTBase<(Int64,Int64,Int64)>, IApplyData
    {
        public DatabaseEntry() : base(default((Int64,Int64,Int64)))
        {
        }

        public DatabaseEntry((Int64,Int64,Int64) data) : base(data)
        {
        }

        public Int64 Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        public Int64 Item3 => Data.Item3;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Int64 item1, out Int64 item2, out Int64 item3)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
        }
    }

    public class Database : UDTBase<IQArray<DatabaseEntry>>, IApplyData
    {
        public Database() : base(new QArray<DatabaseEntry>())
        {
        }

        public Database(IQArray<DatabaseEntry> data) : base(data)
        {
        }

        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct()
        {
        }
    }

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
    }

    public class Node : UDTBase<(IQArray<Qubit>,Int64,Int64,Int64)>, IApplyData
    {
        public Node() : base(default((IQArray<Qubit>,Int64,Int64,Int64)))
        {
        }

        public Node((IQArray<Qubit>,Int64,Int64,Int64) data) : base(data)
        {
        }

        public IQArray<Qubit> Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        public Int64 Item3 => Data.Item3;
        public Int64 Item4 => Data.Item4;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        public void Deconstruct(out IQArray<Qubit> item1, out Int64 item2, out Int64 item3, out Int64 item4)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
            item4 = Data.Item4;
        }
    }

    public partial class GetTimeIndex : Function<QVoid, Int64>, ICallable
    {
        public GetTimeIndex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetTimeIndex";
        String ICallable.FullName => "ShipmentsAssigner.GetTimeIndex";
        public override Func<QVoid, Int64> Body => (__in__) =>
        {
#line 24 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return 1L;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetTimeIndex, QVoid, Int64>(QVoid.Instance);
        }
    }

    public partial class GetElementUsingQuantumIndex : Unitary<(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian)>, ICallable
    {
        public GetElementUsingQuantumIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits);
        }

        String ICallable.Name => "GetElementUsingQuantumIndex";
        String ICallable.FullName => "ShipmentsAssigner.GetElementUsingQuantumIndex";
        protected IUnitary<(Int64,Microsoft.Quantum.Arithmetic.LittleEndian)> MicrosoftQuantumArithmeticIncrementByInteger
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticLittleEndian
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
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

        public override Func<(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian), QVoid> Body => (__in__) =>
        {
            var (qIndex,arr,target) = __in__;
#line 31 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line 32 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(target.Data);
#line 33 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(qIndex);
#line 34 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumArithmeticIncrementByInteger.Partial(new Func<Microsoft.Quantum.Arithmetic.LittleEndian, (Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>((__arg1__) => (arr[i], __arg1__))))).Apply((qIndex, new Microsoft.Quantum.Arithmetic.LittleEndian(target.Data)));
#line 35 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(qIndex);
#line 36 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(target.Data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian), QVoid> AdjointBody => (__in__) =>
        {
            var (qIndex,arr,target) = __in__;
#line hidden
            foreach (var __qsVar0__i__ in RangeReverse.Apply(new Range(0L, (arr.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(target.Data);
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qIndex);
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((__qsVar0__i__, MicrosoftQuantumArithmeticIncrementByInteger.Partial(new Func<Microsoft.Quantum.Arithmetic.LittleEndian, (Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>((__arg1__) => (arr[__qsVar0__i__], __arg1__))))).Adjoint.Apply((qIndex, new Microsoft.Quantum.Arithmetic.LittleEndian(target.Data)));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qIndex);
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(target.Data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qIndex,arr,target)) = __in__;
#line hidden
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, target.Data));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, qIndex));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumArithmeticIncrementByInteger.Partial(new Func<Microsoft.Quantum.Arithmetic.LittleEndian, (Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>((__arg1__) => (arr[i], __arg1__))))).Controlled.Apply((__controlQubits__, (qIndex, new Microsoft.Quantum.Arithmetic.LittleEndian(target.Data))));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, qIndex));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, target.Data));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qIndex,arr,target)) = __in__;
#line hidden
            foreach (var __qsVar0__i__ in RangeReverse.Apply(new Range(0L, (arr.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, target.Data));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, qIndex));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((__qsVar0__i__, MicrosoftQuantumArithmeticIncrementByInteger.Partial(new Func<Microsoft.Quantum.Arithmetic.LittleEndian, (Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>((__arg1__) => (arr[__qsVar0__i__], __arg1__))))).Adjoint.Controlled.Apply((__controlQubits__, (qIndex, new Microsoft.Quantum.Arithmetic.LittleEndian(target.Data))));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, qIndex));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, target.Data));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticIncrementByInteger = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>>(typeof(Microsoft.Quantum.Arithmetic.IncrementByInteger));
            this.MicrosoftQuantumArithmeticLittleEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.LittleEndian));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qIndex, IQArray<Int64> arr, Microsoft.Quantum.Arithmetic.BigEndian target)
        {
            return __m__.Run<GetElementUsingQuantumIndex, (IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian), QVoid>((qIndex, arr, target));
        }
    }

    public partial class DatabaseEntryToArray : Function<DatabaseEntry, IQArray<Int64>>, ICallable
    {
        public DatabaseEntryToArray(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DatabaseEntryToArray";
        String ICallable.FullName => "ShipmentsAssigner.DatabaseEntryToArray";
        public override Func<DatabaseEntry, IQArray<Int64>> Body => (__in__) =>
        {
            var databaseEntry = __in__;
#line 53 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var (shipmentId,time,coordinates) = databaseEntry.Data;
#line 54 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return new QArray<Int64>(shipmentId, time, coordinates);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(DatabaseEntry data) => data;
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, DatabaseEntry databaseEntry)
        {
            return __m__.Run<DatabaseEntryToArray, DatabaseEntry, IQArray<Int64>>(databaseEntry);
        }
    }

    public partial class GetCategorizedEntries : Function<Database, IQArray<IQArray<Int64>>>, ICallable
    {
        public GetCategorizedEntries(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetCategorizedEntries";
        String ICallable.FullName => "ShipmentsAssigner.GetCategorizedEntries";
        protected ICallable MicrosoftQuantumArraysMapped
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<DatabaseEntry, IQArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        public override Func<Database, IQArray<IQArray<Int64>>> Body => (__in__) =>
        {
            var database = __in__;
#line 58 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = (IQArray<IQArray<Int64>>)MicrosoftQuantumArraysMapped.Apply<IQArray<IQArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 59 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 61 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = QArray<IQArray<Int64>>.Create(numProperties);
#line 62 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (databaseEntriesInArr.Length - 1L)))
#line hidden
            {
#line 63 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var entry = (IQArray<Int64>)databaseEntriesInArr[i];
#line 64 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var j in new Range(0L, (numProperties - 1L)))
#line hidden
                {
#line 65 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    categorized.Modify(j, QArray<Int64>.Add(categorized[j], new QArray<Int64>(entry[j])));
                }
            }

#line 69 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return categorized;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMapped = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Mapped<,>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, IQArray<Int64>>>(typeof(DatabaseEntryToArray));
        }

        public override IApplyData __dataIn(Database data) => data;
        public override IApplyData __dataOut(IQArray<IQArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Int64>>> Run(IOperationFactory __m__, Database database)
        {
            return __m__.Run<GetCategorizedEntries, Database, IQArray<IQArray<Int64>>>(database);
        }
    }

    public partial class GetPropertyLengths : Function<Database, IQArray<Int64>>, ICallable
    {
        public GetPropertyLengths(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetPropertyLengths";
        String ICallable.FullName => "ShipmentsAssigner.GetPropertyLengths";
        protected ICallable MicrosoftQuantumArraysMapped
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<IQArray<Int64>, Int64> MicrosoftQuantumMathMax
        {
            get;
            set;
        }

        protected ICallable<DatabaseEntry, IQArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        protected ICallable<Database, IQArray<IQArray<Int64>>> GetCategorizedEntries
        {
            get;
            set;
        }

        public override Func<Database, IQArray<Int64>> Body => (__in__) =>
        {
            var database = __in__;
#line 73 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = (IQArray<IQArray<Int64>>)MicrosoftQuantumArraysMapped.Apply<IQArray<IQArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 74 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 76 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = (IQArray<IQArray<Int64>>)GetCategorizedEntries.Apply(database);
#line 78 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lengths = QArray<Int64>.Create(numProperties);
#line 79 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numProperties - 1L)))
#line hidden
            {
#line 80 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                lengths.Modify(i, MicrosoftQuantumMathBitSizeI.Apply(MicrosoftQuantumMathMax.Apply(categorized[i])));
            }

#line 83 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return lengths;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMapped = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Mapped<,>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.MicrosoftQuantumMathMax = this.Factory.Get<ICallable<IQArray<Int64>, Int64>>(typeof(Microsoft.Quantum.Math.Max));
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, IQArray<Int64>>>(typeof(DatabaseEntryToArray));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, IQArray<IQArray<Int64>>>>(typeof(GetCategorizedEntries));
        }

        public override IApplyData __dataIn(Database data) => data;
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Database database)
        {
            return __m__.Run<GetPropertyLengths, Database, IQArray<Int64>>(database);
        }
    }

    public partial class LoadProperty : Unitary<(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>, ICallable
    {
        public LoadProperty(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits);
        }

        String ICallable.Name => "LoadProperty";
        String ICallable.FullName => "ShipmentsAssigner.LoadProperty";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Database, IQArray<IQArray<Int64>>> GetCategorizedEntries
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian)> GetElementUsingQuantumIndex
        {
            get;
            set;
        }

        protected ICallable<Database, IQArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64), QVoid> Body => (__in__) =>
        {
            var (qIndex,database,target,propertyIndex) = __in__;
#line 88 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = (IQArray<IQArray<Int64>>)GetCategorizedEntries.Apply(database);
#line 89 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numCategories = categorized.Length;
#line 90 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementLengths = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line 91 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementTarget = (IQArray<Qubit>)target.Data?.Slice(new Range(0L, (elementLengths[propertyIndex] - 1L)));
#line 93 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            GetElementUsingQuantumIndex.Apply((qIndex, categorized[propertyIndex], new Microsoft.Quantum.Arithmetic.BigEndian(elementTarget)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (qIndex,database,target,propertyIndex) = __in__;
#line hidden
            var __qsVar0__categorized__ = (IQArray<IQArray<Int64>>)GetCategorizedEntries.Apply(database);
#line hidden
            var __qsVar1__numCategories__ = __qsVar0__categorized__.Length;
#line hidden
            var __qsVar2__elementLengths__ = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line hidden
            var __qsVar3__elementTarget__ = (IQArray<Qubit>)target.Data?.Slice(new Range(0L, (__qsVar2__elementLengths__[propertyIndex] - 1L)));
#line hidden
            GetElementUsingQuantumIndex.Adjoint.Apply((qIndex, __qsVar0__categorized__[propertyIndex], new Microsoft.Quantum.Arithmetic.BigEndian(__qsVar3__elementTarget__)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qIndex,database,target,propertyIndex)) = __in__;
#line hidden
            var categorized = (IQArray<IQArray<Int64>>)GetCategorizedEntries.Apply(database);
#line hidden
            var numCategories = categorized.Length;
#line hidden
            var elementLengths = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line hidden
            var elementTarget = (IQArray<Qubit>)target.Data?.Slice(new Range(0L, (elementLengths[propertyIndex] - 1L)));
#line hidden
            GetElementUsingQuantumIndex.Controlled.Apply((__controlQubits__, (qIndex, categorized[propertyIndex], new Microsoft.Quantum.Arithmetic.BigEndian(elementTarget))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qIndex,database,target,propertyIndex)) = __in__;
#line hidden
            var __qsVar0__categorized__ = (IQArray<IQArray<Int64>>)GetCategorizedEntries.Apply(database);
#line hidden
            var __qsVar1__numCategories__ = __qsVar0__categorized__.Length;
#line hidden
            var __qsVar2__elementLengths__ = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line hidden
            var __qsVar3__elementTarget__ = (IQArray<Qubit>)target.Data?.Slice(new Range(0L, (__qsVar2__elementLengths__[propertyIndex] - 1L)));
#line hidden
            GetElementUsingQuantumIndex.Adjoint.Controlled.Apply((__controlQubits__, (qIndex, __qsVar0__categorized__[propertyIndex], new Microsoft.Quantum.Arithmetic.BigEndian(__qsVar3__elementTarget__))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, IQArray<IQArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.GetElementUsingQuantumIndex = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Int64>,Microsoft.Quantum.Arithmetic.BigEndian)>>(typeof(GetElementUsingQuantumIndex));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, IQArray<Int64>>>(typeof(GetPropertyLengths));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qIndex, Database database, Microsoft.Quantum.Arithmetic.BigEndian target, Int64 propertyIndex)
        {
            return __m__.Run<LoadProperty, (IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64), QVoid>((qIndex, database, target, propertyIndex));
        }
    }

    public partial class _ValidTimes : Unitary<(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian)>, ICallable
    {
        public _ValidTimes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits, ((IApplyData)Data.Item4?.Data)?.Qubits);
        }

        String ICallable.Name => "_ValidTimes";
        String ICallable.FullName => "ShipmentsAssigner._ValidTimes";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticBigEndianAsLittleEndian
        {
            get;
            set;
        }

        protected IUnitary<(Microsoft.Quantum.Arithmetic.LittleEndian,Microsoft.Quantum.Arithmetic.LittleEndian,Qubit)> MicrosoftQuantumArithmeticCompareUsingRippleCarry
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Arithmetic.LittleEndian)> MicrosoftQuantumArithmeticIncrementByInteger
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<QVoid, Int64> GetTimeIndex
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)> LoadProperty
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Qubit)> UtilsCompareXIfAllZero
        {
            get;
            set;
        }

        protected ICallable UtilsGeneralConcatArrays
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian), QVoid> Body => (__in__) =>
        {
            var (qIndices,database,lastTime,isInvalidLE) = __in__;
#line 146 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numStops = database.Data.Length;
#line 147 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var timeLength = lastTime.Data.Length;
#line 149 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line hidden
                {
#line 154 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var (time,toggles,zeroTests) = (Allocate.Apply(timeLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 155 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumCanonSwapReverseRegister.Apply(time);
#line 156 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        var timeBE = new Microsoft.Quantum.Arithmetic.BigEndian(time);
#line 157 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        var invalidToggle = toggles[0L];
#line 158 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        var isNotZero = zeroTests[0L];
#line 159 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        var qIndex = (IQArray<Qubit>)qIndices[i];
#line 161 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        var loadFunc = LoadProperty.Partial(new Func<(IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian), (IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>((__arg3__) => (__arg3__.Item1, database, __arg3__.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line 162 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        loadFunc.Apply((qIndex, timeBE));
#line 164 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumIntrinsicX.Apply(isNotZero);
#line 165 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        UtilsCompareXIfAllZero.Apply((qIndex, isNotZero));
#line 167 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumIntrinsicX.Apply(invalidToggle);
#line 168 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Apply((MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(timeBE), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), invalidToggle));
#line 170 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumArithmeticIncrementByInteger.Controlled.Apply((new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE)));
#line 172 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Adjoint.Apply((MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(timeBE), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), invalidToggle));
#line 173 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumIntrinsicX.Apply(invalidToggle);
#line 175 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        if ((i > 0L))
                        {
#line 176 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(isNotZero);
#line 177 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                            {
#line 178 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                                var qIndicesToTest = (IQArray<Qubit>)UtilsGeneralConcatArrays.Apply<IQArray<Qubit>>(qIndices?.Slice(new Range((i - j), (i - 1L))));
#line 179 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                                var fullControlReg = (IQArray<Qubit>)QArray<Qubit>.Add(qIndicesToTest, new QArray<Qubit>(isNotZero));
#line 180 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Arithmetic.BigEndian, (IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian)>((__arg4__) => (qIndices[((i - j) - 1L)], __arg4__))))).Apply((fullControlReg, lastTime));
                            }

#line 182 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(isNotZero);
                        }

#line 184 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        foreach (var j in new Range(0L, (lastTime.Data.Length - 1L)))
#line hidden
                        {
#line 185 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            MicrosoftQuantumIntrinsicSWAP.Controlled.Apply((new QArray<Qubit>(isNotZero), (lastTime.Data[j], time[j])));
                        }

#line 188 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        UtilsCompareXIfAllZero.Apply((qIndex, isNotZero));
#line 189 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumIntrinsicX.Apply(isNotZero);
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(time);
#line hidden
                        Release.Apply(toggles);
#line hidden
                        Release.Apply(zeroTests);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian), QVoid> AdjointBody => (__in__) =>
        {
            var (qIndices,database,lastTime,isInvalidLE) = __in__;
#line hidden
            var __qsVar0__numStops__ = database.Data.Length;
#line hidden
            var __qsVar1__timeLength__ = lastTime.Data.Length;
#line hidden
            foreach (var __qsVar2__i__ in RangeReverse.Apply(new Range(0L, (__qsVar0__numStops__ - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var (__qsVar3__time__,__qsVar4__toggles__,__qsVar5__zeroTests__) = (Allocate.Apply(__qsVar1__timeLength__), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line hidden
                        var __qsVar6__timeBE__ = new Microsoft.Quantum.Arithmetic.BigEndian(__qsVar3__time__);
#line hidden
                        var __qsVar7__invalidToggle__ = __qsVar4__toggles__[0L];
#line hidden
                        var __qsVar8__isNotZero__ = __qsVar5__zeroTests__[0L];
#line hidden
                        var __qsVar9__qIndex__ = (IQArray<Qubit>)qIndices[__qsVar2__i__];
#line hidden
                        var __qsVar10__loadFunc__ = LoadProperty.Partial(new Func<(IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian), (IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>((__arg3__) => (__arg3__.Item1, database, __arg3__.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(__qsVar8__isNotZero__);
#line hidden
                        UtilsCompareXIfAllZero.Adjoint.Apply((__qsVar9__qIndex__, __qsVar8__isNotZero__));
#line hidden
                        foreach (var __qsVar14__j__ in RangeReverse.Apply(new Range(0L, (lastTime.Data.Length - 1L))))
#line hidden
                        {
#line hidden
                            MicrosoftQuantumIntrinsicSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>(__qsVar8__isNotZero__), (lastTime.Data[__qsVar14__j__], __qsVar3__time__[__qsVar14__j__])));
                        }

#line hidden
                        if ((__qsVar2__i__ > 0L))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(__qsVar8__isNotZero__);
#line hidden
                            foreach (var __qsVar11__j__ in RangeReverse.Apply(new Range(0L, (__qsVar2__i__ - 1L))))
#line hidden
                            {
#line hidden
                                var __qsVar12__qIndicesToTest__ = (IQArray<Qubit>)UtilsGeneralConcatArrays.Apply<IQArray<Qubit>>(qIndices?.Slice(new Range((__qsVar2__i__ - __qsVar11__j__), (__qsVar2__i__ - 1L))));
#line hidden
                                var __qsVar13__fullControlReg__ = (IQArray<Qubit>)QArray<Qubit>.Add(__qsVar12__qIndicesToTest__, new QArray<Qubit>(__qsVar8__isNotZero__));
#line hidden
                                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, __qsVar10__loadFunc__.Adjoint.Partial(new Func<Microsoft.Quantum.Arithmetic.BigEndian, (IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian)>((__arg4__) => (qIndices[((__qsVar2__i__ - __qsVar11__j__) - 1L)], __arg4__))))).Adjoint.Apply((__qsVar13__fullControlReg__, lastTime));
                            }

#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(__qsVar8__isNotZero__);
                        }

#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(__qsVar7__invalidToggle__);
#line hidden
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Adjoint.Adjoint.Apply((MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(__qsVar6__timeBE__), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), __qsVar7__invalidToggle__));
#line hidden
                        MicrosoftQuantumArithmeticIncrementByInteger.Controlled.Adjoint.Apply((new QArray<Qubit>(__qsVar8__isNotZero__, __qsVar7__invalidToggle__), (1L, isInvalidLE)));
#line hidden
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Adjoint.Apply((MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(__qsVar6__timeBE__), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), __qsVar7__invalidToggle__));
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(__qsVar7__invalidToggle__);
#line hidden
                        UtilsCompareXIfAllZero.Adjoint.Apply((__qsVar9__qIndex__, __qsVar8__isNotZero__));
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(__qsVar8__isNotZero__);
#line hidden
                        __qsVar10__loadFunc__.Adjoint.Apply((__qsVar9__qIndex__, __qsVar6__timeBE__));
#line hidden
                        MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(__qsVar3__time__);
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(__qsVar3__time__);
#line hidden
                        Release.Apply(__qsVar4__toggles__);
#line hidden
                        Release.Apply(__qsVar5__zeroTests__);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qIndices,database,lastTime,isInvalidLE)) = __in__;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var timeLength = lastTime.Data.Length;
#line hidden
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line hidden
                {
#line hidden
                    var (time,toggles,zeroTests) = (Allocate.Apply(timeLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line hidden
                        MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, time));
#line hidden
                        var timeBE = new Microsoft.Quantum.Arithmetic.BigEndian(time);
#line hidden
                        var invalidToggle = toggles[0L];
#line hidden
                        var isNotZero = zeroTests[0L];
#line hidden
                        var qIndex = (IQArray<Qubit>)qIndices[i];
#line hidden
                        var loadFunc = LoadProperty.Partial(new Func<(IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian), (IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>((__arg3__) => (__arg3__.Item1, database, __arg3__.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line hidden
                        loadFunc.Controlled.Apply((__controlQubits__, (qIndex, timeBE)));
#line hidden
                        MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, isNotZero));
#line hidden
                        UtilsCompareXIfAllZero.Controlled.Apply((__controlQubits__, (qIndex, isNotZero)));
#line hidden
                        MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, invalidToggle));
#line hidden
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(timeBE), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), invalidToggle)));
#line hidden
                        MicrosoftQuantumArithmeticIncrementByInteger.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE))));
#line hidden
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(timeBE), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), invalidToggle)));
#line hidden
                        MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, invalidToggle));
#line hidden
                        if ((i > 0L))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, isNotZero));
#line hidden
                            foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                            {
#line hidden
                                var qIndicesToTest = (IQArray<Qubit>)UtilsGeneralConcatArrays.Apply<IQArray<Qubit>>(qIndices?.Slice(new Range((i - j), (i - 1L))));
#line hidden
                                var fullControlReg = (IQArray<Qubit>)QArray<Qubit>.Add(qIndicesToTest, new QArray<Qubit>(isNotZero));
#line hidden
                                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Arithmetic.BigEndian, (IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian)>((__arg4__) => (qIndices[((i - j) - 1L)], __arg4__))))).Controlled.Apply((__controlQubits__, (fullControlReg, lastTime)));
                            }

#line hidden
                            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, isNotZero));
                        }

#line hidden
                        foreach (var j in new Range(0L, (lastTime.Data.Length - 1L)))
#line hidden
                        {
#line hidden
                            MicrosoftQuantumIntrinsicSWAP.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(isNotZero), (lastTime.Data[j], time[j]))));
                        }

#line hidden
                        UtilsCompareXIfAllZero.Controlled.Apply((__controlQubits__, (qIndex, isNotZero)));
#line hidden
                        MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, isNotZero));
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(time);
#line hidden
                        Release.Apply(toggles);
#line hidden
                        Release.Apply(zeroTests);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qIndices,database,lastTime,isInvalidLE)) = __in__;
#line hidden
            var __qsVar0__numStops__ = database.Data.Length;
#line hidden
            var __qsVar1__timeLength__ = lastTime.Data.Length;
#line hidden
            foreach (var __qsVar2__i__ in RangeReverse.Apply(new Range(0L, (__qsVar0__numStops__ - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var (__qsVar3__time__,__qsVar4__toggles__,__qsVar5__zeroTests__) = (Allocate.Apply(__qsVar1__timeLength__), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line hidden
                        var __qsVar6__timeBE__ = new Microsoft.Quantum.Arithmetic.BigEndian(__qsVar3__time__);
#line hidden
                        var __qsVar7__invalidToggle__ = __qsVar4__toggles__[0L];
#line hidden
                        var __qsVar8__isNotZero__ = __qsVar5__zeroTests__[0L];
#line hidden
                        var __qsVar9__qIndex__ = (IQArray<Qubit>)qIndices[__qsVar2__i__];
#line hidden
                        var __qsVar10__loadFunc__ = LoadProperty.Partial(new Func<(IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian), (IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>((__arg3__) => (__arg3__.Item1, database, __arg3__.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, __qsVar8__isNotZero__));
#line hidden
                        UtilsCompareXIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar9__qIndex__, __qsVar8__isNotZero__)));
#line hidden
                        foreach (var __qsVar14__j__ in RangeReverse.Apply(new Range(0L, (lastTime.Data.Length - 1L))))
#line hidden
                        {
#line hidden
                            MicrosoftQuantumIntrinsicSWAP.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(__qsVar8__isNotZero__), (lastTime.Data[__qsVar14__j__], __qsVar3__time__[__qsVar14__j__]))));
                        }

#line hidden
                        if ((__qsVar2__i__ > 0L))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, __qsVar8__isNotZero__));
#line hidden
                            foreach (var __qsVar11__j__ in RangeReverse.Apply(new Range(0L, (__qsVar2__i__ - 1L))))
#line hidden
                            {
#line hidden
                                var __qsVar12__qIndicesToTest__ = (IQArray<Qubit>)UtilsGeneralConcatArrays.Apply<IQArray<Qubit>>(qIndices?.Slice(new Range((__qsVar2__i__ - __qsVar11__j__), (__qsVar2__i__ - 1L))));
#line hidden
                                var __qsVar13__fullControlReg__ = (IQArray<Qubit>)QArray<Qubit>.Add(__qsVar12__qIndicesToTest__, new QArray<Qubit>(__qsVar8__isNotZero__));
#line hidden
                                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, __qsVar10__loadFunc__.Adjoint.Partial(new Func<Microsoft.Quantum.Arithmetic.BigEndian, (IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian)>((__arg4__) => (qIndices[((__qsVar2__i__ - __qsVar11__j__) - 1L)], __arg4__))))).Adjoint.Controlled.Apply((__controlQubits__, (__qsVar13__fullControlReg__, lastTime)));
                            }

#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, __qsVar8__isNotZero__));
                        }

#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, __qsVar7__invalidToggle__));
#line hidden
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(__qsVar6__timeBE__), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), __qsVar7__invalidToggle__)));
#line hidden
                        MicrosoftQuantumArithmeticIncrementByInteger.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(__qsVar8__isNotZero__, __qsVar7__invalidToggle__), (1L, isInvalidLE))));
#line hidden
                        MicrosoftQuantumArithmeticCompareUsingRippleCarry.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(__qsVar6__timeBE__), MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(lastTime), __qsVar7__invalidToggle__)));
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, __qsVar7__invalidToggle__));
#line hidden
                        UtilsCompareXIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar9__qIndex__, __qsVar8__isNotZero__)));
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, __qsVar8__isNotZero__));
#line hidden
                        __qsVar10__loadFunc__.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar9__qIndex__, __qsVar6__timeBE__)));
#line hidden
                        MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, __qsVar3__time__));
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(__qsVar3__time__);
#line hidden
                        Release.Apply(__qsVar4__toggles__);
#line hidden
                        Release.Apply(__qsVar5__zeroTests__);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumArithmeticBigEndianAsLittleEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndianAsLittleEndian));
            this.MicrosoftQuantumArithmeticCompareUsingRippleCarry = this.Factory.Get<IUnitary<(Microsoft.Quantum.Arithmetic.LittleEndian,Microsoft.Quantum.Arithmetic.LittleEndian,Qubit)>>(typeof(Microsoft.Quantum.Arithmetic.CompareUsingRippleCarry));
            this.MicrosoftQuantumArithmeticIncrementByInteger = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>>(typeof(Microsoft.Quantum.Arithmetic.IncrementByInteger));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.GetTimeIndex = this.Factory.Get<ICallable<QVoid, Int64>>(typeof(GetTimeIndex));
            this.LoadProperty = this.Factory.Get<IUnitary<(IQArray<Qubit>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Int64)>>(typeof(LoadProperty));
            this.UtilsCompareXIfAllZero = this.Factory.Get<IUnitary<(IQArray<Qubit>,Qubit)>>(typeof(Utils.Compare.XIfAllZero));
            this.UtilsGeneralConcatArrays = this.Factory.Get<ICallable>(typeof(Utils.General.ConcatArrays<>));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> qIndices, Database database, Microsoft.Quantum.Arithmetic.BigEndian lastTime, Microsoft.Quantum.Arithmetic.LittleEndian isInvalidLE)
        {
            return __m__.Run<_ValidTimes, (IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian), QVoid>((qIndices, database, lastTime, isInvalidLE));
        }
    }

    public partial class CreateIndices : Function<(IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>), IQArray<IQArray<Qubit>>>, ICallable
    {
        public CreateIndices(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "CreateIndices";
        String ICallable.FullName => "ShipmentsAssigner.CreateIndices";
        public override Func<(IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>), IQArray<IQArray<Qubit>>> Body => (__in__) =>
        {
            var (qubits,numStops,lenIndex,numProperties,propertyLengths) = __in__;
#line 299 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var qIndices = QArray<IQArray<Qubit>>.Create(numStops);
#line 300 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line 301 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var startIndex = (i * lenIndex);
#line 302 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var endIndex = ((startIndex + lenIndex) - 1L);
#line 304 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                qIndices.Modify(i, qubits?.Slice(new Range(startIndex, endIndex)));
            }

#line 307 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return qIndices;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Qubit>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Qubit>>> Run(IOperationFactory __m__, IQArray<Qubit> qubits, Int64 numStops, Int64 lenIndex, Int64 numProperties, IQArray<Int64> propertyLengths)
        {
            return __m__.Run<CreateIndices, (IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>), IQArray<IQArray<Qubit>>>((qubits, numStops, lenIndex, numProperties, propertyLengths));
        }
    }

    public partial class Oracle : Unitary<(IQArray<Qubit>,Database,Qubit)>, ICallable
    {
        public Oracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Database,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Database,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Oracle";
        String ICallable.FullName => "ShipmentsAssigner.Oracle";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticLittleEndian
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

        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>), IQArray<IQArray<Qubit>>> CreateIndices
        {
            get;
            set;
        }

        protected ICallable<Database, IQArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian)> _ValidTimes
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Qubit)> UtilsCompareXIfAllZero
        {
            get;
            set;
        }

        protected ICallable<IQArray<Int64>, Int64> UtilsGeneralSumIntArray
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Database,Qubit), QVoid> Body => (__in__) =>
        {
            var (qubits,database,ancilla) = __in__;
#line 317 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numStops = database.Data.Length;
#line 318 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lenIndex = (qubits.Length / numStops);
#line 320 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var propertyLengths = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line 321 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = propertyLengths.Length;
#line 322 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var shipmentIdLength = propertyLengths[0L];
#line 323 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var timeLength = propertyLengths[1L];
#line 324 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var coordinatesLength = propertyLengths[2L];
#line 326 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var qIndices = (IQArray<IQArray<Qubit>>)CreateIndices.Apply((qubits, numStops, lenIndex, numProperties, propertyLengths));
#line 328 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var targetLength = UtilsGeneralSumIntArray.Apply(propertyLengths);
#line hidden
            {
#line 330 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var (lastTime,inValid) = (Allocate.Apply(propertyLengths[1L]), Allocate.Apply(MicrosoftQuantumMathBitSizeI.Apply(numStops)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 331 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var lastTimeBE = new Microsoft.Quantum.Arithmetic.BigEndian(lastTime);
#line 332 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var inValidLE = new Microsoft.Quantum.Arithmetic.LittleEndian(inValid);
#line 334 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    _ValidTimes.Apply((qIndices, database, lastTimeBE, inValidLE));
#line 336 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfAllZero.Apply((inValid, ancilla));
#line 338 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    _ValidTimes.Adjoint.Apply((qIndices, database, lastTimeBE, inValidLE));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(lastTime);
#line hidden
                    Release.Apply(inValid);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Database,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (qubits,database,ancilla) = __in__;
#line hidden
            var __qsVar0__numStops__ = database.Data.Length;
#line hidden
            var __qsVar1__lenIndex__ = (qubits.Length / __qsVar0__numStops__);
#line hidden
            var __qsVar2__propertyLengths__ = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line hidden
            var __qsVar3__numProperties__ = __qsVar2__propertyLengths__.Length;
#line hidden
            var __qsVar4__shipmentIdLength__ = __qsVar2__propertyLengths__[0L];
#line hidden
            var __qsVar5__timeLength__ = __qsVar2__propertyLengths__[1L];
#line hidden
            var __qsVar6__coordinatesLength__ = __qsVar2__propertyLengths__[2L];
#line hidden
            var __qsVar7__qIndices__ = (IQArray<IQArray<Qubit>>)CreateIndices.Apply((qubits, __qsVar0__numStops__, __qsVar1__lenIndex__, __qsVar3__numProperties__, __qsVar2__propertyLengths__));
#line hidden
            var __qsVar8__targetLength__ = UtilsGeneralSumIntArray.Apply(__qsVar2__propertyLengths__);
#line hidden
            {
#line hidden
                var (__qsVar9__lastTime__,__qsVar10__inValid__) = (Allocate.Apply(__qsVar2__propertyLengths__[1L]), Allocate.Apply(MicrosoftQuantumMathBitSizeI.Apply(__qsVar0__numStops__)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar11__lastTimeBE__ = new Microsoft.Quantum.Arithmetic.BigEndian(__qsVar9__lastTime__);
#line hidden
                    var __qsVar12__inValidLE__ = new Microsoft.Quantum.Arithmetic.LittleEndian(__qsVar10__inValid__);
#line hidden
                    _ValidTimes.Adjoint.Adjoint.Apply((__qsVar7__qIndices__, database, __qsVar11__lastTimeBE__, __qsVar12__inValidLE__));
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Apply((__qsVar10__inValid__, ancilla));
#line hidden
                    _ValidTimes.Adjoint.Apply((__qsVar7__qIndices__, database, __qsVar11__lastTimeBE__, __qsVar12__inValidLE__));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(__qsVar9__lastTime__);
#line hidden
                    Release.Apply(__qsVar10__inValid__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Database,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qubits,database,ancilla)) = __in__;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var lenIndex = (qubits.Length / numStops);
#line hidden
            var propertyLengths = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line hidden
            var numProperties = propertyLengths.Length;
#line hidden
            var shipmentIdLength = propertyLengths[0L];
#line hidden
            var timeLength = propertyLengths[1L];
#line hidden
            var coordinatesLength = propertyLengths[2L];
#line hidden
            var qIndices = (IQArray<IQArray<Qubit>>)CreateIndices.Apply((qubits, numStops, lenIndex, numProperties, propertyLengths));
#line hidden
            var targetLength = UtilsGeneralSumIntArray.Apply(propertyLengths);
#line hidden
            {
#line hidden
                var (lastTime,inValid) = (Allocate.Apply(propertyLengths[1L]), Allocate.Apply(MicrosoftQuantumMathBitSizeI.Apply(numStops)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var lastTimeBE = new Microsoft.Quantum.Arithmetic.BigEndian(lastTime);
#line hidden
                    var inValidLE = new Microsoft.Quantum.Arithmetic.LittleEndian(inValid);
#line hidden
                    _ValidTimes.Controlled.Apply((__controlQubits__, (qIndices, database, lastTimeBE, inValidLE)));
#line hidden
                    UtilsCompareXIfAllZero.Controlled.Apply((__controlQubits__, (inValid, ancilla)));
#line hidden
                    _ValidTimes.Adjoint.Controlled.Apply((__controlQubits__, (qIndices, database, lastTimeBE, inValidLE)));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(lastTime);
#line hidden
                    Release.Apply(inValid);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Database,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qubits,database,ancilla)) = __in__;
#line hidden
            var __qsVar0__numStops__ = database.Data.Length;
#line hidden
            var __qsVar1__lenIndex__ = (qubits.Length / __qsVar0__numStops__);
#line hidden
            var __qsVar2__propertyLengths__ = (IQArray<Int64>)GetPropertyLengths.Apply(database);
#line hidden
            var __qsVar3__numProperties__ = __qsVar2__propertyLengths__.Length;
#line hidden
            var __qsVar4__shipmentIdLength__ = __qsVar2__propertyLengths__[0L];
#line hidden
            var __qsVar5__timeLength__ = __qsVar2__propertyLengths__[1L];
#line hidden
            var __qsVar6__coordinatesLength__ = __qsVar2__propertyLengths__[2L];
#line hidden
            var __qsVar7__qIndices__ = (IQArray<IQArray<Qubit>>)CreateIndices.Apply((qubits, __qsVar0__numStops__, __qsVar1__lenIndex__, __qsVar3__numProperties__, __qsVar2__propertyLengths__));
#line hidden
            var __qsVar8__targetLength__ = UtilsGeneralSumIntArray.Apply(__qsVar2__propertyLengths__);
#line hidden
            {
#line hidden
                var (__qsVar9__lastTime__,__qsVar10__inValid__) = (Allocate.Apply(__qsVar2__propertyLengths__[1L]), Allocate.Apply(MicrosoftQuantumMathBitSizeI.Apply(__qsVar0__numStops__)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar11__lastTimeBE__ = new Microsoft.Quantum.Arithmetic.BigEndian(__qsVar9__lastTime__);
#line hidden
                    var __qsVar12__inValidLE__ = new Microsoft.Quantum.Arithmetic.LittleEndian(__qsVar10__inValid__);
#line hidden
                    _ValidTimes.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar7__qIndices__, database, __qsVar11__lastTimeBE__, __qsVar12__inValidLE__)));
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar10__inValid__, ancilla)));
#line hidden
                    _ValidTimes.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar7__qIndices__, database, __qsVar11__lastTimeBE__, __qsVar12__inValidLE__)));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(__qsVar9__lastTime__);
#line hidden
                    Release.Apply(__qsVar10__inValid__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumArithmeticLittleEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.LittleEndian));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.CreateIndices = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64,Int64,Int64,IQArray<Int64>), IQArray<IQArray<Qubit>>>>(typeof(CreateIndices));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, IQArray<Int64>>>(typeof(GetPropertyLengths));
            this._ValidTimes = this.Factory.Get<IUnitary<(IQArray<IQArray<Qubit>>,Database,Microsoft.Quantum.Arithmetic.BigEndian,Microsoft.Quantum.Arithmetic.LittleEndian)>>(typeof(_ValidTimes));
            this.UtilsCompareXIfAllZero = this.Factory.Get<IUnitary<(IQArray<Qubit>,Qubit)>>(typeof(Utils.Compare.XIfAllZero));
            this.UtilsGeneralSumIntArray = this.Factory.Get<ICallable<IQArray<Int64>, Int64>>(typeof(Utils.General.SumIntArray));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Database,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qubits, Database database, Qubit ancilla)
        {
            return __m__.Run<Oracle, (IQArray<Qubit>,Database,Qubit), QVoid>((qubits, database, ancilla));
        }
    }

    public partial class OracleAugmented : Unitary<(IQArray<Qubit>,Database,Qubit,Qubit)>, ICallable
    {
        public OracleAugmented(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Database,Qubit,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Database,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "OracleAugmented";
        String ICallable.FullName => "ShipmentsAssigner.OracleAugmented";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Database,Qubit)> Oracle
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Database,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (qubits,database,ancilla,aug) = __in__;
#line hidden
            {
#line 355 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var toggles = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 357 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var toggle = toggles[0L];
#line 359 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(ancilla);
#line 360 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(ancilla);
#line 362 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    Oracle.Apply((qubits, database, toggle));
#line 364 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(aug, toggle), ancilla));
#line 366 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    Oracle.Adjoint.Apply((qubits, database, toggle));
#line 368 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((qubits, ancilla));
#line 377 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(ancilla);
#line 378 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(ancilla);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(toggles);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Database,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (qubits,database,ancilla,aug) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__toggles__ = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar1__toggle__ = __qsVar0__toggles__[0L];
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(ancilla);
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(ancilla);
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((qubits, ancilla));
#line hidden
                    Oracle.Adjoint.Adjoint.Apply((qubits, database, __qsVar1__toggle__));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(aug, __qsVar1__toggle__), ancilla));
#line hidden
                    Oracle.Adjoint.Apply((qubits, database, __qsVar1__toggle__));
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(ancilla);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(ancilla);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(__qsVar0__toggles__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Database,Qubit,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qubits,database,ancilla,aug)) = __in__;
#line hidden
            {
#line hidden
                var toggles = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var toggle = toggles[0L];
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    Oracle.Controlled.Apply((__controlQubits__, (qubits, database, toggle)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(aug, toggle), ancilla)));
#line hidden
                    Oracle.Adjoint.Controlled.Apply((__controlQubits__, (qubits, database, toggle)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (qubits, ancilla)));
#line hidden
                    MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, ancilla));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(toggles);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Database,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qubits,database,ancilla,aug)) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__toggles__ = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar1__toggle__ = __qsVar0__toggles__[0L];
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (qubits, ancilla)));
#line hidden
                    Oracle.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (qubits, database, __qsVar1__toggle__)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(aug, __qsVar1__toggle__), ancilla)));
#line hidden
                    Oracle.Adjoint.Controlled.Apply((__controlQubits__, (qubits, database, __qsVar1__toggle__)));
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, ancilla));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(__qsVar0__toggles__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.Oracle = this.Factory.Get<IUnitary<(IQArray<Qubit>,Database,Qubit)>>(typeof(Oracle));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Database,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qubits, Database database, Qubit ancilla, Qubit aug)
        {
            return __m__.Run<OracleAugmented, (IQArray<Qubit>,Database,Qubit,Qubit), QVoid>((qubits, database, ancilla, aug));
        }
    }

    public partial class GroverStateAugmentedOracle : Unitary<(Int64,IQArray<Qubit>,Database)>, ICallable
    {
        public GroverStateAugmentedOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>,Database)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>,Database) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "GroverStateAugmentedOracle";
        String ICallable.FullName => "ShipmentsAssigner.GroverStateAugmentedOracle";
        protected ICallable MicrosoftQuantumArraysExclude
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysTail
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Database,Qubit,Qubit)> OracleAugmented
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>,Database), QVoid> Body => (__in__) =>
        {
            var (flagIndex,qubits,database) = __in__;
#line 389 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var flag = qubits[flagIndex];
#line 390 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var stateQubits = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(flagIndex), qubits));
#line 392 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, stateQubits));
#line 393 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            OracleAugmented.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(stateQubits), database, flag, MicrosoftQuantumArraysTail.Apply<Qubit>(stateQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IQArray<Qubit>,Database), QVoid> AdjointBody => (__in__) =>
        {
            var (flagIndex,qubits,database) = __in__;
#line hidden
            var __qsVar0__flag__ = qubits[flagIndex];
#line hidden
            var __qsVar1__stateQubits__ = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(flagIndex), qubits));
#line hidden
            OracleAugmented.Adjoint.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar1__stateQubits__), database, __qsVar0__flag__, MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar1__stateQubits__)));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, __qsVar1__stateQubits__));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,Database)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(flagIndex,qubits,database)) = __in__;
#line hidden
            var flag = qubits[flagIndex];
#line hidden
            var stateQubits = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(flagIndex), qubits));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, stateQubits)));
#line hidden
            OracleAugmented.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(stateQubits), database, flag, MicrosoftQuantumArraysTail.Apply<Qubit>(stateQubits))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,Database)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(flagIndex,qubits,database)) = __in__;
#line hidden
            var __qsVar0__flag__ = qubits[flagIndex];
#line hidden
            var __qsVar1__stateQubits__ = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(flagIndex), qubits));
#line hidden
            OracleAugmented.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar1__stateQubits__), database, __qsVar0__flag__, MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar1__stateQubits__))));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, __qsVar1__stateQubits__)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Exclude<>));
            this.MicrosoftQuantumArraysMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Most<>));
            this.MicrosoftQuantumArraysTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Tail<>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.OracleAugmented = this.Factory.Get<IUnitary<(IQArray<Qubit>,Database,Qubit,Qubit)>>(typeof(OracleAugmented));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>,Database) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 flagIndex, IQArray<Qubit> qubits, Database database)
        {
            return __m__.Run<GroverStateAugmentedOracle, (Int64,IQArray<Qubit>,Database), QVoid>((flagIndex, qubits, database));
        }
    }

    public partial class GroverPow : Unitary<(Int64,IQArray<Qubit>,Database)>, ICallable
    {
        public GroverPow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>,Database)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>,Database) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "GroverPow";
        String ICallable.FullName => "ShipmentsAssigner.GroverPow";
        protected ICallable MicrosoftQuantumArraysMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysTail
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(Pauli,Double,Qubit)> MicrosoftQuantumIntrinsicR
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Database,Qubit,Qubit)> OracleAugmented
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>,Database), QVoid> Body => (__in__) =>
        {
            var (power,qubits,database) = __in__;
#line 403 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var ancilla = qubits[0L];
#line 404 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var inputQubits = (IQArray<Qubit>)qubits?.Slice(new Range(1L, (qubits.Length - 1L)));
#line 405 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var aug = MicrosoftQuantumArraysTail.Apply<Qubit>(inputQubits);
#line 406 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var ans = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(inputQubits);
#line 408 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(1L, power))
#line hidden
            {
#line 409 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                OracleAugmented.Apply((ans, database, ancilla, aug));
#line 410 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, inputQubits));
#line 411 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, inputQubits));
#line 412 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumIntrinsicZ.Controlled.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(inputQubits), MicrosoftQuantumArraysTail.Apply<Qubit>(inputQubits)));
#line 413 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, inputQubits));
#line 414 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliI, (2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)), qubits[0L]));
#line 415 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, inputQubits));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IQArray<Qubit>,Database), QVoid> AdjointBody => (__in__) =>
        {
            var (power,qubits,database) = __in__;
#line hidden
            var __qsVar0__ancilla__ = qubits[0L];
#line hidden
            var __qsVar1__inputQubits__ = (IQArray<Qubit>)qubits?.Slice(new Range(1L, (qubits.Length - 1L)));
#line hidden
            var __qsVar2__aug__ = MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar1__inputQubits__);
#line hidden
            var __qsVar3__ans__ = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar1__inputQubits__);
#line hidden
            foreach (var __qsVar4__i__ in RangeReverse.Apply(new Range(1L, power)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, __qsVar1__inputQubits__));
#line hidden
                MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliI, (2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)), qubits[0L]));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicX, __qsVar1__inputQubits__));
#line hidden
                MicrosoftQuantumIntrinsicZ.Controlled.Adjoint.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar1__inputQubits__), MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar1__inputQubits__)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicX, __qsVar1__inputQubits__));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, __qsVar1__inputQubits__));
#line hidden
                OracleAugmented.Adjoint.Apply((__qsVar3__ans__, database, __qsVar0__ancilla__, __qsVar2__aug__));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,Database)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(power,qubits,database)) = __in__;
#line hidden
            var ancilla = qubits[0L];
#line hidden
            var inputQubits = (IQArray<Qubit>)qubits?.Slice(new Range(1L, (qubits.Length - 1L)));
#line hidden
            var aug = MicrosoftQuantumArraysTail.Apply<Qubit>(inputQubits);
#line hidden
            var ans = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(inputQubits);
#line hidden
            foreach (var i in new Range(1L, power))
#line hidden
            {
#line hidden
                OracleAugmented.Controlled.Apply((__controlQubits__, (ans, database, ancilla, aug)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, inputQubits)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, inputQubits)));
#line hidden
                MicrosoftQuantumIntrinsicZ.Controlled.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(inputQubits), MicrosoftQuantumArraysTail.Apply<Qubit>(inputQubits))));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, inputQubits)));
#line hidden
                MicrosoftQuantumIntrinsicR.Controlled.Apply((__controlQubits__, (Pauli.PauliI, (2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)), qubits[0L])));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, inputQubits)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,Database)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(power,qubits,database)) = __in__;
#line hidden
            var __qsVar0__ancilla__ = qubits[0L];
#line hidden
            var __qsVar1__inputQubits__ = (IQArray<Qubit>)qubits?.Slice(new Range(1L, (qubits.Length - 1L)));
#line hidden
            var __qsVar2__aug__ = MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar1__inputQubits__);
#line hidden
            var __qsVar3__ans__ = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar1__inputQubits__);
#line hidden
            foreach (var __qsVar4__i__ in RangeReverse.Apply(new Range(1L, power)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, __qsVar1__inputQubits__)));
#line hidden
                MicrosoftQuantumIntrinsicR.Adjoint.Controlled.Apply((__controlQubits__, (Pauli.PauliI, (2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)), qubits[0L])));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, __qsVar1__inputQubits__)));
#line hidden
                MicrosoftQuantumIntrinsicZ.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar1__inputQubits__), MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar1__inputQubits__))));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, __qsVar1__inputQubits__)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, __qsVar1__inputQubits__)));
#line hidden
                OracleAugmented.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar3__ans__, database, __qsVar0__ancilla__, __qsVar2__aug__)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Most<>));
            this.MicrosoftQuantumArraysTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Tail<>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicR = this.Factory.Get<IUnitary<(Pauli,Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.OracleAugmented = this.Factory.Get<IUnitary<(IQArray<Qubit>,Database,Qubit,Qubit)>>(typeof(OracleAugmented));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>,Database) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 power, IQArray<Qubit> qubits, Database database)
        {
            return __m__.Run<GroverPow, (Int64,IQArray<Qubit>,Database), QVoid>((power, qubits, database));
        }
    }

    public partial class CountSolutions : Operation<(Int64,Double,Database), Int64>, ICallable
    {
        public CountSolutions(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Double,Database)>, IApplyData
        {
            public In((Int64,Double,Database) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CountSolutions";
        String ICallable.FullName => "ShipmentsAssigner.CountSolutions";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticBigEndianAsLittleEndian
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Arithmetic.LittleEndian, Int64> MicrosoftQuantumArithmeticMeasureInteger
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumConvertIntAsString
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumMathPowD
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumMathRound
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSin
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Qubit>,Database)> GroverPow
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> UtilsMathCeilLogBase2
        {
            get;
            set;
        }

        public override Func<(Int64,Double,Database), Int64> Body => (__in__) =>
        {
            var (bitAccuracy,maxError,database) = __in__;
#line 449 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numElements = database.Data.Length;
#line 450 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var maxDbIndex = (numElements - 1L);
#line 451 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var bitsForMaxDbIndex = MicrosoftQuantumMathBitSizeI.Apply(maxDbIndex);
#line 452 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lenT = (bitAccuracy + UtilsMathCeilLogBase2.Apply((2D + (1D / (2D * maxError)))));
#line 453 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("t: {0}", lenT));
#line 455 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numSolutions = -(1L);
#line hidden
            {
#line 456 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var (control,target) = (Allocate.Apply(lenT), Allocate.Apply(((bitsForMaxDbIndex * numElements) + 3L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 457 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var controlBE = new Microsoft.Quantum.Arithmetic.BigEndian(control);
#line 458 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var ancilla = target[0L];
#line 460 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(ancilla);
#line 461 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, QArray<Qubit>.Add(control, target)));
#line 462 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    foreach (var i in new Range(0L, (control.Length - 1L)))
#line hidden
                    {
#line 463 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        GroverPow.Controlled.Apply((new QArray<Qubit>(control[((control.Length - 1L) - i)]), (2L.Pow(i), target, database)));
                    }

#line 465 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonQFT.Adjoint.Apply(controlBE);
#line 467 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var fiBE = MicrosoftQuantumArithmeticMeasureInteger.Apply(MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(controlBE));
#line 468 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var numSolutionsD = (MicrosoftQuantumMathPowD.Apply((MicrosoftQuantumMathSin.Apply((MicrosoftQuantumConvertIntAsDouble.Apply(fiBE) / 2D)), 2D)) * MicrosoftQuantumConvertIntAsDouble.Apply(2L.Pow(QArray<Qubit>.Add(control, target).Length)));
#line 470 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicMessage.Apply(("numSolutions: " + MicrosoftQuantumConvertIntAsString.Apply(MicrosoftQuantumMathRound.Apply(numSolutionsD))));
#line 510 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(QArray<Qubit>.Add(control, target));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(control);
#line hidden
                    Release.Apply(target);
                }
            }

#line 513 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return numSolutions;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumArithmeticBigEndianAsLittleEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndianAsLittleEndian));
            this.MicrosoftQuantumArithmeticMeasureInteger = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.LittleEndian, Int64>>(typeof(Microsoft.Quantum.Arithmetic.MeasureInteger));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumConvertIntAsString = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Convert.IntAsString));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.MicrosoftQuantumMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Math.PowD));
            this.MicrosoftQuantumMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Math.Round));
            this.MicrosoftQuantumMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sin));
            this.GroverPow = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>,Database)>>(typeof(GroverPow));
            this.UtilsMathCeilLogBase2 = this.Factory.Get<ICallable<Double, Int64>>(typeof(Utils.Math.CeilLogBase2));
        }

        public override IApplyData __dataIn((Int64,Double,Database) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 bitAccuracy, Double maxError, Database database)
        {
            return __m__.Run<CountSolutions, (Int64,Double,Database), Int64>((bitAccuracy, maxError, database));
        }
    }
}