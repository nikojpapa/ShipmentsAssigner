#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetDatabase\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetDatabase\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":64}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":79}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":117,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":118,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":134,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":150,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadStop\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":151,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_OracleImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":173,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numStops\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetLength\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"shipmentIdLength\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":6,\"Column\":13},\"Item2\":{\"Line\":6,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"timeLength\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":7,\"Column\":13},\"Item2\":{\"Line\":7,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lastTime\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":8,\"Column\":13},\"Item2\":{\"Line\":8,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"isInvalidLE\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":9,\"Column\":13},\"Item2\":{\"Line\":9,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lastTarget\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":10,\"Column\":13},\"Item2\":{\"Line\":10,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_OracleImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":185,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_OracleImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":256,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":259,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":265,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
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

    public class GetDatabase : Function<QVoid, Database>, ICallable
    {
        public GetDatabase(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetDatabase";
        String ICallable.FullName => "ShipmentsAssigner.GetDatabase";
        public override Func<QVoid, Database> Body => (__in) =>
        {
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return new Database(new QArray<DatabaseEntry>(new DatabaseEntry((0L, 0L, 0L)), new DatabaseEntry((1L, 1L, 1L)), new DatabaseEntry((2L, 2L, 2L))));
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

    public class GetElementUsingQuantumIndex : Unitary<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)>, ICallable
    {
        public GetElementUsingQuantumIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits);
        }

        String ICallable.Name => "GetElementUsingQuantumIndex";
        String ICallable.FullName => "ShipmentsAssigner.GetElementUsingQuantumIndex";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
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

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian), QVoid> Body => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (database.Length - 1L)))
#line hidden
            {
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(target.Data);
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (database[i], _arg1))))).Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data)));
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(target.Data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (database.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(target.Data);
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (database[i], _arg1))))).Adjoint.Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data)));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(target.Data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target)) = __in;
#line hidden
            foreach (var i in new Range(0L, (database.Length - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (database[i], _arg1))))).Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data))));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target)) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (database.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (database[i], _arg1))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data))));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonIntegerIncrementLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementLE));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, QArray<Int64> database, Microsoft.Quantum.Canon.BigEndian target)
        {
            return __m__.Run<GetElementUsingQuantumIndex, (QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian), QVoid>((qIndex, database, target));
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
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var (shipmentId,time,coordinates) = databaseEntry.Data;
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = MicrosoftQuantumCanonMap.Apply<QArray<QArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = new QArray<QArray<Int64>>(numProperties);
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (databaseEntriesInArr.Length - 1L)))
#line hidden
            {
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var entry = databaseEntriesInArr[i];
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var j in new Range(0L, (numProperties - 1L)))
#line hidden
                {
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    categorized[j] = (categorized[j] + new QArray<Int64>()
                    {entry[j]});
                }
            }

#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = MicrosoftQuantumCanonMap.Apply<QArray<QArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lengths = new QArray<Int64>(numProperties);
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numProperties - 1L)))
#line hidden
            {
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                lengths[i] = MicrosoftQuantumCanonBitSize.Apply(MicrosoftQuantumCanonMax.Apply(categorized[i]));
            }

#line 115 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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

    public class LoadStop : Unitary<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)>, ICallable
    {
        public LoadStop(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)>, IApplyData
        {
            public In((QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits);
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

        protected IUnitary<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)> GetElementUsingQuantumIndex
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> UtilsMathClassicalSum
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian), QVoid> Body => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numCategories = categorized.Length;
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var startIndex = 0L;
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (elementLengths.Length - 1L)))
#line hidden
            {
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var endIndex = ((startIndex + elementLengths[i]) - 1L);
#line 127 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var elementTarget = target.Data?.Slice(new Range(startIndex, endIndex));
#line 129 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                GetElementUsingQuantumIndex.Apply((qIndex?.Copy(), categorized[i], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy())));
#line 131 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                startIndex = (endIndex + 1L);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (qIndex,database,target) = __in;
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numCategories = categorized.Length;
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var endIndex = (UtilsMathClassicalSum.Apply(elementLengths) - 1L);
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range((elementLengths.Length - 1L), -(1L), 0L))
#line hidden
            {
#line 142 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var startIndex = ((endIndex - elementLengths[i]) + 1L);
#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var elementTarget = target.Data?.Slice(new Range(startIndex, endIndex));
#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                GetElementUsingQuantumIndex.Adjoint.Apply((qIndex?.Copy(), categorized[i], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy())));
#line 147 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                endIndex = (startIndex - 1L);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target)) = __in;
#line hidden
            var categorized = GetCategorizedEntries.Apply(database);
#line hidden
            var numCategories = categorized.Length;
#line hidden
            var elementLengths = GetPropertyLengths.Apply(database);
#line hidden
            var startIndex = 0L;
#line hidden
            foreach (var i in new Range(0L, (elementLengths.Length - 1L)))
#line hidden
            {
#line hidden
                var endIndex = ((startIndex + elementLengths[i]) - 1L);
#line hidden
                var elementTarget = target.Data?.Slice(new Range(startIndex, endIndex));
#line hidden
                GetElementUsingQuantumIndex.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), categorized[i], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy()))));
#line hidden
                startIndex = (endIndex + 1L);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target)) = __in;
#line hidden
            var categorized = GetCategorizedEntries.Apply(database);
#line hidden
            var numCategories = categorized.Length;
#line hidden
            var elementLengths = GetPropertyLengths.Apply(database);
#line hidden
            var endIndex = (UtilsMathClassicalSum.Apply(elementLengths) - 1L);
#line hidden
            foreach (var i in new Range((elementLengths.Length - 1L), -(1L), 0L))
#line hidden
            {
#line hidden
                var startIndex = ((endIndex - elementLengths[i]) + 1L);
#line hidden
                var elementTarget = target.Data?.Slice(new Range(startIndex, endIndex));
#line hidden
                GetElementUsingQuantumIndex.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), categorized[i], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy()))));
#line hidden
                endIndex = (startIndex - 1L);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetCategorizedEntries = this.Factory.Get<ICallable<Database, QArray<QArray<Int64>>>>(typeof(GetCategorizedEntries));
            this.GetElementUsingQuantumIndex = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(GetElementUsingQuantumIndex));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this.UtilsMathClassicalSum = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Utils.Math.ClassicalSum));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, Database database, Microsoft.Quantum.Canon.BigEndian target)
        {
            return __m__.Run<LoadStop, (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian), QVoid>((qIndex, database, target));
        }
    }

    public class _OracleImpl : Adjointable<(Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)>, ICallable
    {
        public _OracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item7?.Data)?.Qubits, ((IApplyData)Data.Item8?.Data)?.Qubits, ((IApplyData)Data.Item9)?.Qubits);
        }

        String ICallable.Name => "_OracleImpl";
        String ICallable.FullName => "ShipmentsAssigner._OracleImpl";
        protected IUnitary<(Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.BigEndian,Qubit)> MicrosoftQuantumCanonApplyRippleCarryComparatorBE
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonIntegerIncrementLE
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)> LoadStop
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Qubit)> UtilsCompareXIfAllZero
        {
            get;
            set;
        }

        protected ICallable UtilsGeneralConcatArrays
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (numStops,targetLength,qIndices,database,shipmentIdLength,timeLength,lastTime,isInvalidLE,lastTarget) = __in;
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line hidden
                {
#line 188 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var (target,toggles,zeroTests) = (Allocate.Apply(targetLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line 189 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var invalidToggle = toggles[0L];
#line 190 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var isNotZero = zeroTests[0L];
#line 191 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var qIndex = qIndices[i];
#line 192 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var time = new Microsoft.Quantum.Canon.BigEndian(target?.Slice(new Range(shipmentIdLength, ((shipmentIdLength + timeLength) - 1L))));
#line 194 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var loadFunc = LoadStop.Partial(new Func<(QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian), (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (_arg1.Item1, database, _arg1.Item2)));
#line 195 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    loadFunc.Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.BigEndian(target?.Copy())));
#line 209 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(isNotZero);
#line 210 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfAllZero.Apply((qIndex?.Copy(), isNotZero));
#line 212 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(invalidToggle);
#line 213 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Apply((time, lastTime, invalidToggle));
#line 224 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Apply((new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE)));
#line 226 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Apply((time, lastTime, invalidToggle));
#line 227 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(invalidToggle);
#line 229 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    if ((i > 0L))
                    {
#line 230 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumPrimitiveX.Apply(isNotZero);
#line 231 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                        {
#line 232 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            var qIndicesToTest = UtilsGeneralConcatArrays.Apply<QArray<Qubit>>(qIndices?.Slice(new Range((i - j), (i - 1L))));
#line 233 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            var fullControlReg = (qIndicesToTest + new QArray<Qubit>()
                            {isNotZero});
#line 243 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Canon.BigEndian, (QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (qIndices[((i - j) - 1L)], _arg1))))).Apply((fullControlReg?.Copy(), new Microsoft.Quantum.Canon.BigEndian(lastTarget?.Copy())));
                        }

#line 245 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumPrimitiveX.Apply(isNotZero);
                    }

#line 247 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    foreach (var j in new Range(0L, (targetLength - 1L)))
#line hidden
                    {
#line 248 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
                        {isNotZero}, (lastTarget[j], target[j])));
                    }

#line 251 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfAllZero.Apply((qIndex?.Copy(), isNotZero));
#line 252 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(isNotZero);
#line hidden
                    Release.Apply(target);
#line hidden
                    Release.Apply(toggles);
#line hidden
                    Release.Apply(zeroTests);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (numStops,targetLength,qIndices,database,shipmentIdLength,timeLength,lastTime,isInvalidLE,lastTarget) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (numStops - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var (target,toggles,zeroTests) = (Allocate.Apply(targetLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    var invalidToggle = toggles[0L];
#line hidden
                    var isNotZero = zeroTests[0L];
#line hidden
                    var qIndex = qIndices[i];
#line hidden
                    var time = new Microsoft.Quantum.Canon.BigEndian(target?.Slice(new Range(shipmentIdLength, ((shipmentIdLength + timeLength) - 1L))));
#line hidden
                    var loadFunc = LoadStop.Partial(new Func<(QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian), (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (_arg1.Item1, database, _arg1.Item2)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Apply((qIndex?.Copy(), isNotZero));
#line hidden
                    foreach (var j in RangeReverse.Apply(new Range(0L, (targetLength - 1L))))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
                        {isNotZero}, (lastTarget[j], target[j])));
                    }

#line hidden
                    if ((i > 0L))
                    {
#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
#line hidden
                        foreach (var j in RangeReverse.Apply(new Range(0L, (i - 1L))))
#line hidden
                        {
#line hidden
                            var qIndicesToTest = UtilsGeneralConcatArrays.Apply<QArray<Qubit>>(qIndices?.Slice(new Range((i - j), (i - 1L))));
#line hidden
                            var fullControlReg = (qIndicesToTest + new QArray<Qubit>()
                            {isNotZero});
#line hidden
                            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Canon.BigEndian, (QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (qIndices[((i - j) - 1L)], _arg1))))).Adjoint.Apply((fullControlReg?.Copy(), new Microsoft.Quantum.Canon.BigEndian(lastTarget?.Copy())));
                        }

#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
                    }

#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(invalidToggle);
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Adjoint.Apply((time, lastTime, invalidToggle));
#line hidden
                    MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Adjoint.Apply((new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE)));
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Apply((time, lastTime, invalidToggle));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(invalidToggle);
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Apply((qIndex?.Copy(), isNotZero));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
#line hidden
                    loadFunc.Adjoint.Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.BigEndian(target?.Copy())));
#line hidden
                    Release.Apply(target);
#line hidden
                    Release.Apply(toggles);
#line hidden
                    Release.Apply(zeroTests);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyRippleCarryComparatorBE = this.Factory.Get<IUnitary<(Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.BigEndian,Qubit)>>(typeof(Microsoft.Quantum.Canon.ApplyRippleCarryComparatorBE));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonIntegerIncrementLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementLE));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.LoadStop = this.Factory.Get<IUnitary<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian)>>(typeof(LoadStop));
            this.UtilsCompareXIfAllZero = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(Utils.Compare.XIfAllZero));
            this.UtilsGeneralConcatArrays = this.Factory.Get<ICallable>(typeof(Utils.General.ConcatArrays<>));
        }

        public override IApplyData __dataIn((Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 numStops, Int64 targetLength, QArray<QArray<Qubit>> qIndices, Database database, Int64 shipmentIdLength, Int64 timeLength, Microsoft.Quantum.Canon.BigEndian lastTime, Microsoft.Quantum.Canon.LittleEndian isInvalidLE, QArray<Qubit> lastTarget)
        {
            return __m__.Run<_OracleImpl, (Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>), QVoid>((numStops, targetLength, qIndices, database, shipmentIdLength, timeLength, lastTime, isInvalidLE, lastTarget));
        }
    }

    public class Oracle : Operation<(QArray<Qubit>,Database,Qubit), QVoid>, ICallable
    {
        public Oracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Database,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Database,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Oracle";
        String ICallable.FullName => "ShipmentsAssigner.Oracle";
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

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected IAdjointable<(Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)> _OracleImpl
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Qubit)> UtilsCompareXIfAllZero
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Database,Qubit), QVoid> Body => (__in) =>
        {
            var (qubits,database,ancilla) = __in;
#line 267 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numStops = database.Data.Length;
#line 268 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lenIndex = (qubits.Length / numStops);
#line 270 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var propertyLengths = GetPropertyLengths.Apply(database);
#line 271 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = propertyLengths.Length;
#line 272 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var shipmentIdLength = propertyLengths[0L];
#line 273 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var timeLength = propertyLengths[1L];
#line 274 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var coordinatesLength = propertyLengths[2L];
#line 276 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var qIndices = new QArray<QArray<Qubit>>(numStops);
#line 277 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line 278 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var startIndex = (i * lenIndex);
#line 279 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var endIndex = ((startIndex + lenIndex) - 1L);
#line 281 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                qIndices[i] = qubits?.Slice(new Range(startIndex, endIndex));
            }

#line 284 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var targetLength = 0L;
#line 285 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numProperties - 1L)))
#line hidden
            {
#line 286 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                targetLength = (targetLength + propertyLengths[i]);
            }

#line hidden
            {
#line 289 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var (lastTarget,isValid) = (Allocate.Apply(targetLength), Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numStops)));
#line 290 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var lastTime = new Microsoft.Quantum.Canon.BigEndian(lastTarget?.Slice(new Range(shipmentIdLength, ((shipmentIdLength + timeLength) - 1L))));
#line 291 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var isValidLE = new Microsoft.Quantum.Canon.LittleEndian(isValid?.Copy());
#line 293 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                _OracleImpl.Apply((numStops, targetLength, qIndices?.Copy(), database, shipmentIdLength, timeLength, lastTime, isValidLE, lastTarget?.Copy()));
#line 295 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                UtilsCompareXIfAllZero.Apply((isValid?.Copy(), ancilla));
#line 297 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                _OracleImpl.Adjoint.Apply((numStops, targetLength, qIndices?.Copy(), database, shipmentIdLength, timeLength, lastTime, isValidLE, lastTarget?.Copy()));
#line hidden
                Release.Apply(lastTarget);
#line hidden
                Release.Apply(isValid);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this._OracleImpl = this.Factory.Get<IAdjointable<(Int64,Int64,QArray<QArray<Qubit>>,Database,Int64,Int64,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian,QArray<Qubit>)>>(typeof(_OracleImpl));
            this.UtilsCompareXIfAllZero = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(Utils.Compare.XIfAllZero));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Database,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, Database database, Qubit ancilla)
        {
            return __m__.Run<Oracle, (QArray<Qubit>,Database,Qubit), QVoid>((qubits, database, ancilla));
        }
    }
}