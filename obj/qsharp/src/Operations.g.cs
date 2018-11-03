#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Window\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Window\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Window\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":15}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetDatabase\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetDatabase\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"TimesAreValid\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nodes\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"TimesAreValid\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"endIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":73,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Slice\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":75,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":64}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":79}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":101,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":133,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":134,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":135,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":138,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":138,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetShipmentIdFromDatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetShipmentIdFromDatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetTimeFromDatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":147,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetTimeFromDatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":147,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCoordinatesFromDatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":151,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCoordinatesFromDatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":151,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":155,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":155,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":170,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":170,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":184,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":184,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStopsInSpecifiedOrder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":200,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":84}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStopsInSpecifiedOrder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":200,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
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

        public static UDTPartial<P, (Int64,Int64,Int64), DatabaseEntry> Partial<P>(Func<P, (Int64,Int64,Int64)> mapper) => new UDTPartial<P, (Int64,Int64,Int64), DatabaseEntry>(mapper);
    }

    public class Database : UDTBase<QArray<DatabaseEntry>>, IApplyData
    {
        public Database() : base(new QArray<DatabaseEntry>())
        {
        }

        public Database(QArray<DatabaseEntry> data) : base(data)
        {
        }

        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct()
        {
        }

        public static UDTPartial<P, QArray<DatabaseEntry>, Database> Partial<P>(Func<P, QArray<DatabaseEntry>> mapper) => new UDTPartial<P, QArray<DatabaseEntry>, Database>(mapper);
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

    public class Window : UDTBase<(Int64,Int64)>, IApplyData
    {
        public Window() : base(default((Int64,Int64)))
        {
        }

        public Window((Int64,Int64) data) : base(data)
        {
        }

        public Int64 Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Int64 item1, out Int64 item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }

        public static UDTPartial<P, (Int64,Int64), Window> Partial<P>(Func<P, (Int64,Int64)> mapper) => new UDTPartial<P, (Int64,Int64), Window>(mapper);
    }

    public class GetDatabase : Function<QVoid, Database>, ICallable
    {
        public GetDatabase(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetDatabase";
        String ICallable.FullName => "ShipmentsAssigner.GetDatabase";
        public override Func<QVoid, Database> Body => (__in) =>
        {
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return new Database(new QArray<DatabaseEntry>(new DatabaseEntry((1L, 1L, 1L)), new DatabaseEntry((2L, 2L, 2L)), new DatabaseEntry((3L, 3L, 3L)), new DatabaseEntry((4L, 4L, 4L)), new DatabaseEntry((5L, 2L, 9L)), new DatabaseEntry((9L, 15L, 13L))));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Database data) => data;
        public static System.Threading.Tasks.Task<Database> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetDatabase, QVoid, Database>(QVoid.Instance);
        }
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
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numNodes = nodes.Length;
#line hidden
            {
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var control = Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numNodes));
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(MicrosoftQuantumCanonTail.Apply<Qubit>(control));
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var lastTime = -(1L);
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
                        UtilsMathQFTAdderInt.Apply((control?.Copy(), -(1L)));
                    }

#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, control?.Copy()));
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((control?.Copy(), target));
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, control?.Copy()));
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    lastTime = time;
                }

#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                lastTime = -(1L);
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var node in nodes)
#line hidden
                {
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var (nodeId,shipmentId,time,coordinates) = node.Data;
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    if ((lastTime <= time))
                    {
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        UtilsMathQFTAdderInt.Apply((control?.Copy(), 1L));
                    }

#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var targetLength = target.Length;
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var sliceLength = ((endIndex - startIndex) + 1L);
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((target.Length, ((endIndex - startIndex) + 1L), String.Format("target not correct length; targetLength: {0}, sliceLength: {1}", targetLength, sliceLength)));
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var slicedArr = arr?.Slice(new Range(startIndex, endIndex));
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (slicedArr.Length - 1L)))
#line hidden
            {
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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

    public class GetElementUsingQuantumIndex : Unitary<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public GetElementUsingQuantumIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GetElementUsingQuantumIndex";
        String ICallable.FullName => "ShipmentsAssigner.GetElementUsingQuantumIndex";
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

        protected IUnitary<(QArray<Qubit>,Int64,Qubit)> UtilsCompareXIfQubitEqualToInt
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Int64)> UtilsMathQFTAdderInt
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (database.Length - 1L)))
#line hidden
            {
#line hidden
                {
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var qubits = Allocate.Apply(1L);
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var toggle = qubits[0L];
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfQubitEqualToInt.Apply((qIndex?.Copy(), i, toggle));
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsMathQFTAdderInt.Controlled.Apply((new QArray<Qubit>()
                    {toggle}, (target?.Copy(), database[i])));
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfQubitEqualToInt.Apply((qIndex?.Copy(), i, toggle));
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (database.Length - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var qubits = Allocate.Apply(1L);
#line hidden
                    var toggle = qubits[0L];
#line hidden
                    UtilsCompareXIfQubitEqualToInt.Adjoint.Apply((qIndex?.Copy(), i, toggle));
#line hidden
                    UtilsMathQFTAdderInt.Controlled.Adjoint.Apply((new QArray<Qubit>()
                    {toggle}, (target?.Copy(), database[i])));
#line hidden
                    UtilsCompareXIfQubitEqualToInt.Adjoint.Apply((qIndex?.Copy(), i, toggle));
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target)) = __in;
#line hidden
            foreach (var i in new Range(0L, (database.Length - 1L)))
#line hidden
            {
#line hidden
                {
#line hidden
                    var qubits = Allocate.Apply(1L);
#line hidden
                    var toggle = qubits[0L];
#line hidden
                    UtilsCompareXIfQubitEqualToInt.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), i, toggle)));
#line hidden
                    UtilsMathQFTAdderInt.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {toggle}, (target?.Copy(), database[i]))));
#line hidden
                    UtilsCompareXIfQubitEqualToInt.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), i, toggle)));
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target)) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (database.Length - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var qubits = Allocate.Apply(1L);
#line hidden
                    var toggle = qubits[0L];
#line hidden
                    UtilsCompareXIfQubitEqualToInt.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), i, toggle)));
#line hidden
                    UtilsMathQFTAdderInt.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {toggle}, (target?.Copy(), database[i]))));
#line hidden
                    UtilsCompareXIfQubitEqualToInt.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), i, toggle)));
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
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.UtilsCompareXIfQubitEqualToInt = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64,Qubit)>>(typeof(Utils.Compare.XIfQubitEqualToInt));
            this.UtilsMathQFTAdderInt = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64)>>(typeof(Utils.Math.QFTAdderInt));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, QArray<Int64> database, QArray<Qubit> target)
        {
            return __m__.Run<GetElementUsingQuantumIndex, (QArray<Qubit>,QArray<Int64>,QArray<Qubit>), QVoid>((qIndex, database, target));
        }
    }

    public class DatabaseEntryToArray : Function<DatabaseEntry, QArray<Int64>>, ICallable
    {
        public DatabaseEntryToArray(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DatabaseEntryToArray";
        String ICallable.FullName => "ShipmentsAssigner.DatabaseEntryToArray";
        public override Func<DatabaseEntry, QArray<Int64>> Body => (__in) =>
        {
            var databaseEntry = __in;
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var (shipmentId,time,coordinates) = databaseEntry.Data;
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return new QArray<Int64>(shipmentId, time, coordinates);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(DatabaseEntry data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, DatabaseEntry databaseEntry)
        {
            return __m__.Run<DatabaseEntryToArray, DatabaseEntry, QArray<Int64>>(databaseEntry);
        }
    }

    public class GetShipmentIdFromDatabaseEntry : Function<DatabaseEntry, Int64>, ICallable
    {
        public GetShipmentIdFromDatabaseEntry(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetShipmentIdFromDatabaseEntry";
        String ICallable.FullName => "ShipmentsAssigner.GetShipmentIdFromDatabaseEntry";
        protected ICallable<DatabaseEntry, QArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        public override Func<DatabaseEntry, Int64> Body => (__in) =>
        {
            var databaseEntry = __in;
#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return DatabaseEntryToArray.Apply(databaseEntry)[0L];
        }

        ;
        public override void Init()
        {
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, QArray<Int64>>>(typeof(DatabaseEntryToArray));
        }

        public override IApplyData __dataIn(DatabaseEntry data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, DatabaseEntry databaseEntry)
        {
            return __m__.Run<GetShipmentIdFromDatabaseEntry, DatabaseEntry, Int64>(databaseEntry);
        }
    }

    public class GetTimeFromDatabaseEntry : Function<DatabaseEntry, Int64>, ICallable
    {
        public GetTimeFromDatabaseEntry(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetTimeFromDatabaseEntry";
        String ICallable.FullName => "ShipmentsAssigner.GetTimeFromDatabaseEntry";
        protected ICallable<DatabaseEntry, QArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        public override Func<DatabaseEntry, Int64> Body => (__in) =>
        {
            var databaseEntry = __in;
#line 149 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return DatabaseEntryToArray.Apply(databaseEntry)[1L];
        }

        ;
        public override void Init()
        {
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, QArray<Int64>>>(typeof(DatabaseEntryToArray));
        }

        public override IApplyData __dataIn(DatabaseEntry data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, DatabaseEntry databaseEntry)
        {
            return __m__.Run<GetTimeFromDatabaseEntry, DatabaseEntry, Int64>(databaseEntry);
        }
    }

    public class GetCoordinatesFromDatabaseEntry : Function<DatabaseEntry, Int64>, ICallable
    {
        public GetCoordinatesFromDatabaseEntry(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetCoordinatesFromDatabaseEntry";
        String ICallable.FullName => "ShipmentsAssigner.GetCoordinatesFromDatabaseEntry";
        protected ICallable<DatabaseEntry, QArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        public override Func<DatabaseEntry, Int64> Body => (__in) =>
        {
            var databaseEntry = __in;
#line 153 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return DatabaseEntryToArray.Apply(databaseEntry)[2L];
        }

        ;
        public override void Init()
        {
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, QArray<Int64>>>(typeof(DatabaseEntryToArray));
        }

        public override IApplyData __dataIn(DatabaseEntry data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, DatabaseEntry databaseEntry)
        {
            return __m__.Run<GetCoordinatesFromDatabaseEntry, DatabaseEntry, Int64>(databaseEntry);
        }
    }

    public class GetCategorizedEntries : Function<Database, QArray<QArray<Int64>>>, ICallable
    {
        public GetCategorizedEntries(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetCategorizedEntries";
        String ICallable.FullName => "ShipmentsAssigner.GetCategorizedEntries";
        protected ICallable MicrosoftQuantumCanonMap
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<DatabaseEntry, QArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        public override Func<Database, QArray<QArray<Int64>>> Body => (__in) =>
        {
            var database = __in;
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = MicrosoftQuantumCanonMap.Apply<QArray<QArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 158 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = new QArray<QArray<Int64>>(numProperties);
#line 161 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (databaseEntriesInArr.Length - 1L)))
#line hidden
            {
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var entry = databaseEntriesInArr[i];
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var j in new Range(0L, (numProperties - 1L)))
#line hidden
                {
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    categorized[j] = (categorized[j] + new QArray<Int64>()
                    {entry[j]});
                }
            }

#line 168 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return categorized;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMap = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Map<,>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, QArray<Int64>>>(typeof(DatabaseEntryToArray));
        }

        public override IApplyData __dataIn(Database data) => data;
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Database database)
        {
            return __m__.Run<GetCategorizedEntries, Database, QArray<QArray<Int64>>>(database);
        }
    }

    public class GetPropertyLengths : Function<Database, QArray<Int64>>, ICallable
    {
        public GetPropertyLengths(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetPropertyLengths";
        String ICallable.FullName => "ShipmentsAssigner.GetPropertyLengths";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMap
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> MicrosoftQuantumCanonMax
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<DatabaseEntry, QArray<Int64>> DatabaseEntryToArray
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<QArray<Int64>>> GetCategorizedEntries
        {
            get;
            set;
        }

        public override Func<Database, QArray<Int64>> Body => (__in) =>
        {
            var database = __in;
#line 172 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = MicrosoftQuantumCanonMap.Apply<QArray<QArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 173 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 175 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 177 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lengths = new QArray<Int64>(numProperties);
#line 178 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numProperties - 1L)))
#line hidden
            {
#line 179 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                lengths[i] = MicrosoftQuantumCanonBitSize.Apply(MicrosoftQuantumCanonMax.Apply(categorized[i]));
            }

#line 182 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return lengths;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonMap = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Map<,>));
            this.MicrosoftQuantumCanonMax = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Microsoft.Quantum.Canon.Max));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.DatabaseEntryToArray = this.Factory.Get<ICallable<DatabaseEntry, QArray<Int64>>>(typeof(DatabaseEntryToArray));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
        }

        public override IApplyData __dataIn(Database data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Database database)
        {
            return __m__.Run<GetPropertyLengths, Database, QArray<Int64>>(database);
        }
    }

    public class LoadStop : Operation<(QArray<Qubit>,Database,QArray<Qubit>), QVoid>, ICallable
    {
        public LoadStop(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Database,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,Database,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "LoadStop";
        String ICallable.FullName => "ShipmentsAssigner.LoadStop";
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

        protected IUnitary<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)> GetElementUsingQuantumIndex
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Database,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line 186 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numCategories = categorized.Length;
#line 188 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 190 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var startIndex = 0L;
#line 191 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (elementLengths.Length - 1L)))
#line hidden
            {
#line 192 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var endIndex = ((startIndex + elementLengths[i]) - 1L);
#line 193 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var elementTarget = target?.Slice(new Range(startIndex, endIndex));
#line 195 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                GetElementUsingQuantumIndex.Apply((qIndex?.Copy(), categorized[i], elementTarget?.Copy()));
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                startIndex = (endIndex + 1L);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.GetElementUsingQuantumIndex = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>)>>(typeof(GetElementUsingQuantumIndex));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Database,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, Database database, QArray<Qubit> target)
        {
            return __m__.Run<LoadStop, (QArray<Qubit>,Database,QArray<Qubit>), QVoid>((qIndex, database, target));
        }
    }

    public class LoadStopsInSpecifiedOrder : Operation<(QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>), QVoid>, ICallable
    {
        public LoadStopsInSpecifiedOrder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>)>, IApplyData
        {
            public In((QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "LoadStopsInSpecifiedOrder";
        String ICallable.FullName => "ShipmentsAssigner.LoadStopsInSpecifiedOrder";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
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

        protected ICallable<(QArray<Qubit>,Database,QArray<Qubit>), QVoid> LoadStop
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, String> UtilsGeneralRegisterToString
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>), QVoid> Body => (__in) =>
        {
            var (qIndices,database,target) = __in;
#line 202 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 203 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 204 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (qIndices.Length - 1L)))
#line hidden
            {
#line 205 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var qIndex = qIndices[i];
#line 206 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var entryTarget = target[i];
#line 207 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                Message.Apply(("qIndex: " + UtilsGeneralRegisterToString.Apply(qIndex?.Copy())));
#line 209 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                LoadStop.Apply((qIndex?.Copy(), database, entryTarget?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this.LoadStop = this.Factory.Get<ICallable<(QArray<Qubit>,Database,QArray<Qubit>), QVoid>>(typeof(LoadStop));
            this.UtilsGeneralRegisterToString = this.Factory.Get<ICallable<QArray<Qubit>, String>>(typeof(Utils.General.RegisterToString));
        }

        public override IApplyData __dataIn((QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<QArray<Qubit>> qIndices, Database database, QArray<QArray<Qubit>> target)
        {
            return __m__.Run<LoadStopsInSpecifiedOrder, (QArray<QArray<Qubit>>,Database,QArray<QArray<Qubit>>), QVoid>((qIndices, database, target));
        }
    }
}