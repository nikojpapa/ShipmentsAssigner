#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"NodeRegisterLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":28}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"__arg__\"]},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Node\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetTimeIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetTimeIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetDatabase\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetDatabase\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":74}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":35,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetElementUsingQuantumIndex\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":56,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseEntry\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntry\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"DatabaseEntryToArray\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetCategorizedEntries\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"GetPropertyLengths\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":93,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndex\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"propertyIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":94,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":103,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":104,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"LoadProperty\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":105,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qIndices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lastTime\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"isInvalidLE\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"BigEndian\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"LittleEndian\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":152,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":201,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":202,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"_ValidTimes\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":203,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CreateIndices\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":298,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numStops\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"lenIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numProperties\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"propertyLengths\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":6,\"Column\":13},\"Item2\":{\"Line\":6,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CreateIndices\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":298,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":317,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":323,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":349,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":350,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":351,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":354,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":13},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":13},\"Item2\":{\"Line\":3,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aug\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":13},\"Item2\":{\"Line\":5,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":361,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":373,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":374,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OracleAugmented\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":375,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"StateAugmentedOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":378,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"flagIndex\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":73}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"StateAugmentedOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":379,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"StateAugmentedOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":385,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"StateAugmentedOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":386,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"StateAugmentedOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":387,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OraclePow\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":390,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OraclePow\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":391,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OraclePow\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":397,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OraclePow\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":398,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"OraclePow\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":399,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CountSolutions\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":402,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"maxError\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"database\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"Database\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShipmentsAssigner\",\"Name\":\"CountSolutions\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs\",\"Position\":{\"Item1\":402,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
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

    public class GetTimeIndex : Function<QVoid, Int64>, ICallable
    {
        public GetTimeIndex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetTimeIndex";
        String ICallable.FullName => "ShipmentsAssigner.GetTimeIndex";
        public override Func<QVoid, Int64> Body => (__in) =>
        {
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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

    public class GetDatabase : Function<QVoid, Database>, ICallable
    {
        public GetDatabase(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetDatabase";
        String ICallable.FullName => "ShipmentsAssigner.GetDatabase";
        public override Func<QVoid, Database> Body => (__in) =>
        {
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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
            var (qIndex,arr,target) = __in;
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(target.Data);
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(qIndex?.Copy());
#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (arr[i], _arg1))))).Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data)));
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(qIndex?.Copy());
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(target.Data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (qIndex,arr,target) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (arr.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(target.Data);
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qIndex?.Copy());
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (arr[i], _arg1))))).Adjoint.Apply((qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data)));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qIndex?.Copy());
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(target.Data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,arr,target)) = __in;
#line hidden
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), qIndex?.Copy()));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (arr[i], _arg1))))).Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data))));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), qIndex?.Copy()));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,arr,target)) = __in;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (arr.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), target.Data));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qIndex?.Copy()));
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumCanonIntegerIncrementLE.Partial(new Func<Microsoft.Quantum.Canon.LittleEndian, (Int64,Microsoft.Quantum.Canon.LittleEndian)>((_arg1) => (arr[i], _arg1))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), new Microsoft.Quantum.Canon.LittleEndian(target.Data))));
#line hidden
                MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qIndex?.Copy()));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, QArray<Int64> arr, Microsoft.Quantum.Canon.BigEndian target)
        {
            return __m__.Run<GetElementUsingQuantumIndex, (QArray<Qubit>,QArray<Int64>,Microsoft.Quantum.Canon.BigEndian), QVoid>((qIndex, arr, target));
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
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var (shipmentId,time,coordinates) = databaseEntry.Data;
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = MicrosoftQuantumCanonMap.Apply<QArray<QArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = new QArray<QArray<Int64>>(numProperties);
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (databaseEntriesInArr.Length - 1L)))
#line hidden
            {
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var entry = databaseEntriesInArr[i];
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                foreach (var j in new Range(0L, (numProperties - 1L)))
#line hidden
                {
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    categorized[j] = (categorized[j] + new QArray<Int64>()
                    {entry[j]});
                }
            }

#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var databaseEntriesInArr = MicrosoftQuantumCanonMap.Apply<QArray<QArray<Int64>>>((DatabaseEntryToArray, database.Data));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = databaseEntriesInArr[0L].Length;
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lengths = new QArray<Int64>(numProperties);
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numProperties - 1L)))
#line hidden
            {
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                lengths[i] = MicrosoftQuantumCanonBitSize.Apply(MicrosoftQuantumCanonMax.Apply(categorized[i]));
            }

#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
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

    public class LoadProperty : Unitary<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>, ICallable
    {
        public LoadProperty(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits);
        }

        String ICallable.Name => "LoadProperty";
        String ICallable.FullName => "ShipmentsAssigner.LoadProperty";
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

        public override Func<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64), QVoid> Body => (__in) =>
        {
            var (qIndex,database,target,propertyIndex) = __in;
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var categorized = GetCategorizedEntries.Apply(database);
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numCategories = categorized.Length;
#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementLengths = GetPropertyLengths.Apply(database);
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var elementTarget = target.Data?.Slice(new Range(0L, (elementLengths[propertyIndex] - 1L)));
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            GetElementUsingQuantumIndex.Apply((qIndex?.Copy(), categorized[propertyIndex], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (qIndex,database,target,propertyIndex) = __in;
#line hidden
            var categorized = GetCategorizedEntries.Apply(database);
#line hidden
            var numCategories = categorized.Length;
#line hidden
            var elementLengths = GetPropertyLengths.Apply(database);
#line hidden
            var elementTarget = target.Data?.Slice(new Range(0L, (elementLengths[propertyIndex] - 1L)));
#line hidden
            GetElementUsingQuantumIndex.Adjoint.Apply((qIndex?.Copy(), categorized[propertyIndex], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target,propertyIndex)) = __in;
#line hidden
            var categorized = GetCategorizedEntries.Apply(database);
#line hidden
            var numCategories = categorized.Length;
#line hidden
            var elementLengths = GetPropertyLengths.Apply(database);
#line hidden
            var elementTarget = target.Data?.Slice(new Range(0L, (elementLengths[propertyIndex] - 1L)));
#line hidden
            GetElementUsingQuantumIndex.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), categorized[propertyIndex], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qIndex,database,target,propertyIndex)) = __in;
#line hidden
            var categorized = GetCategorizedEntries.Apply(database);
#line hidden
            var numCategories = categorized.Length;
#line hidden
            var elementLengths = GetPropertyLengths.Apply(database);
#line hidden
            var elementTarget = target.Data?.Slice(new Range(0L, (elementLengths[propertyIndex] - 1L)));
#line hidden
            GetElementUsingQuantumIndex.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), categorized[propertyIndex], new Microsoft.Quantum.Canon.BigEndian(elementTarget?.Copy()))));
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
        }

        public override IApplyData __dataIn((QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qIndex, Database database, Microsoft.Quantum.Canon.BigEndian target, Int64 propertyIndex)
        {
            return __m__.Run<LoadProperty, (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64), QVoid>((qIndex, database, target, propertyIndex));
        }
    }

    public class _ValidTimes : Unitary<(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian)>, ICallable
    {
        public _ValidTimes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian)>, IApplyData
        {
            public In((QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits, ((IApplyData)Data.Item4?.Data)?.Qubits);
        }

        String ICallable.Name => "_ValidTimes";
        String ICallable.FullName => "ShipmentsAssigner._ValidTimes";
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

        protected ICallable<QVoid, Int64> GetTimeIndex
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)> LoadProperty
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

        public override Func<(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian), QVoid> Body => (__in) =>
        {
            var (qIndices,database,lastTime,isInvalidLE) = __in;
#line 154 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numStops = database.Data.Length;
#line 155 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var timeLength = lastTime.Data.Length;
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line hidden
                {
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var (time,toggles,zeroTests) = (Allocate.Apply(timeLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonSwapReverseRegister.Apply(time?.Copy());
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var timeBE = new Microsoft.Quantum.Canon.BigEndian(time?.Copy());
#line 165 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var invalidToggle = toggles[0L];
#line 166 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var isNotZero = zeroTests[0L];
#line 167 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var qIndex = qIndices[i];
#line 169 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    var loadFunc = LoadProperty.Partial(new Func<(QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian), (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>((_arg1) => (_arg1.Item1, database, _arg1.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line 170 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    loadFunc.Apply((qIndex?.Copy(), timeBE));
#line 172 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(isNotZero);
#line 173 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfAllZero.Apply((qIndex?.Copy(), isNotZero));
#line 175 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(invalidToggle);
#line 176 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Apply((timeBE, lastTime, invalidToggle));
#line 178 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Apply((new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE)));
#line 180 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Apply((timeBE, lastTime, invalidToggle));
#line 181 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(invalidToggle);
#line 183 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    if ((i > 0L))
                    {
#line 184 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumPrimitiveX.Apply(isNotZero);
#line 185 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                        {
#line 186 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            var qIndicesToTest = UtilsGeneralConcatArrays.Apply<QArray<Qubit>>(qIndices?.Slice(new Range((i - j), (i - 1L))));
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            var fullControlReg = (qIndicesToTest + new QArray<Qubit>()
                            {isNotZero});
#line 188 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Canon.BigEndian, (QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (qIndices[((i - j) - 1L)], _arg1))))).Apply((fullControlReg?.Copy(), lastTime));
                        }

#line 190 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumPrimitiveX.Apply(isNotZero);
                    }

#line 192 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    foreach (var j in new Range(0L, (lastTime.Data.Length - 1L)))
#line hidden
                    {
#line 193 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
                        {isNotZero}, (lastTime.Data[j], time[j])));
                    }

#line 196 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    UtilsCompareXIfAllZero.Apply((qIndex?.Copy(), isNotZero));
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(isNotZero);
#line hidden
                    Release.Apply(time);
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
        public override Func<(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (qIndices,database,lastTime,isInvalidLE) = __in;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var timeLength = lastTime.Data.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (numStops - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var (time,toggles,zeroTests) = (Allocate.Apply(timeLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    var timeBE = new Microsoft.Quantum.Canon.BigEndian(time?.Copy());
#line hidden
                    var invalidToggle = toggles[0L];
#line hidden
                    var isNotZero = zeroTests[0L];
#line hidden
                    var qIndex = qIndices[i];
#line hidden
                    var loadFunc = LoadProperty.Partial(new Func<(QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian), (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>((_arg1) => (_arg1.Item1, database, _arg1.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Apply((qIndex?.Copy(), isNotZero));
#line hidden
                    foreach (var j in RangeReverse.Apply(new Range(0L, (lastTime.Data.Length - 1L))))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
                        {isNotZero}, (lastTime.Data[j], time[j])));
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
                            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Canon.BigEndian, (QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (qIndices[((i - j) - 1L)], _arg1))))).Adjoint.Apply((fullControlReg?.Copy(), lastTime));
                        }

#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
                    }

#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(invalidToggle);
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Adjoint.Apply((timeBE, lastTime, invalidToggle));
#line hidden
                    MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Adjoint.Apply((new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE)));
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Apply((timeBE, lastTime, invalidToggle));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(invalidToggle);
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Apply((qIndex?.Copy(), isNotZero));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(isNotZero);
#line hidden
                    loadFunc.Adjoint.Apply((qIndex?.Copy(), timeBE));
#line hidden
                    MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(time?.Copy());
#line hidden
                    Release.Apply(time);
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
        public override Func<(QArray<Qubit>,(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qIndices,database,lastTime,isInvalidLE)) = __in;
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
                    MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), time?.Copy()));
#line hidden
                    var timeBE = new Microsoft.Quantum.Canon.BigEndian(time?.Copy());
#line hidden
                    var invalidToggle = toggles[0L];
#line hidden
                    var isNotZero = zeroTests[0L];
#line hidden
                    var qIndex = qIndices[i];
#line hidden
                    var loadFunc = LoadProperty.Partial(new Func<(QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian), (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>((_arg1) => (_arg1.Item1, database, _arg1.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line hidden
                    loadFunc.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), timeBE)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
#line hidden
                    UtilsCompareXIfAllZero.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), isNotZero)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), invalidToggle));
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Controlled.Apply((__controlQubits__?.Copy(), (timeBE, lastTime, invalidToggle)));
#line hidden
                    MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE))));
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (timeBE, lastTime, invalidToggle)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), invalidToggle));
#line hidden
                    if ((i > 0L))
                    {
#line hidden
                        MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
#line hidden
                        foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                        {
#line hidden
                            var qIndicesToTest = UtilsGeneralConcatArrays.Apply<QArray<Qubit>>(qIndices?.Slice(new Range((i - j), (i - 1L))));
#line hidden
                            var fullControlReg = (qIndicesToTest + new QArray<Qubit>()
                            {isNotZero});
#line hidden
                            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Canon.BigEndian, (QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (qIndices[((i - j) - 1L)], _arg1))))).Controlled.Apply((__controlQubits__?.Copy(), (fullControlReg?.Copy(), lastTime)));
                        }

#line hidden
                        MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
                    }

#line hidden
                    foreach (var j in new Range(0L, (lastTime.Data.Length - 1L)))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                        {isNotZero}, (lastTime.Data[j], time[j]))));
                    }

#line hidden
                    UtilsCompareXIfAllZero.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), isNotZero)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
#line hidden
                    Release.Apply(time);
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
        public override Func<(QArray<Qubit>,(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qIndices,database,lastTime,isInvalidLE)) = __in;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var timeLength = lastTime.Data.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (numStops - 1L))))
#line hidden
            {
#line hidden
                {
#line hidden
                    var (time,toggles,zeroTests) = (Allocate.Apply(timeLength), Allocate.Apply(1L), Allocate.Apply(1L));
#line hidden
                    var timeBE = new Microsoft.Quantum.Canon.BigEndian(time?.Copy());
#line hidden
                    var invalidToggle = toggles[0L];
#line hidden
                    var isNotZero = zeroTests[0L];
#line hidden
                    var qIndex = qIndices[i];
#line hidden
                    var loadFunc = LoadProperty.Partial(new Func<(QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian), (QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>((_arg1) => (_arg1.Item1, database, _arg1.Item2, GetTimeIndex.Apply(QVoid.Instance))));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), isNotZero)));
#line hidden
                    foreach (var j in RangeReverse.Apply(new Range(0L, (lastTime.Data.Length - 1L))))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                        {isNotZero}, (lastTime.Data[j], time[j]))));
                    }

#line hidden
                    if ((i > 0L))
                    {
#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
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
                            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, loadFunc.Adjoint.Partial(new Func<Microsoft.Quantum.Canon.BigEndian, (QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>((_arg1) => (qIndices[((i - j) - 1L)], _arg1))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (fullControlReg?.Copy(), lastTime)));
                        }

#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
                    }

#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), invalidToggle));
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (timeBE, lastTime, invalidToggle)));
#line hidden
                    MicrosoftQuantumCanonIntegerIncrementLE.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(isNotZero, invalidToggle), (1L, isInvalidLE))));
#line hidden
                    MicrosoftQuantumCanonApplyRippleCarryComparatorBE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (timeBE, lastTime, invalidToggle)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), invalidToggle));
#line hidden
                    UtilsCompareXIfAllZero.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), isNotZero)));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), isNotZero));
#line hidden
                    loadFunc.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndex?.Copy(), timeBE)));
#line hidden
                    MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), time?.Copy()));
#line hidden
                    Release.Apply(time);
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
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.GetTimeIndex = this.Factory.Get<ICallable<QVoid, Int64>>(typeof(GetTimeIndex));
            this.LoadProperty = this.Factory.Get<IUnitary<(QArray<Qubit>,Database,Microsoft.Quantum.Canon.BigEndian,Int64)>>(typeof(LoadProperty));
            this.UtilsCompareXIfAllZero = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(Utils.Compare.XIfAllZero));
            this.UtilsGeneralConcatArrays = this.Factory.Get<ICallable>(typeof(Utils.General.ConcatArrays<>));
        }

        public override IApplyData __dataIn((QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<QArray<Qubit>> qIndices, Database database, Microsoft.Quantum.Canon.BigEndian lastTime, Microsoft.Quantum.Canon.LittleEndian isInvalidLE)
        {
            return __m__.Run<_ValidTimes, (QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian), QVoid>((qIndices, database, lastTime, isInvalidLE));
        }
    }

    public class CreateIndices : Function<(QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>), QArray<QArray<Qubit>>>, ICallable
    {
        public CreateIndices(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "CreateIndices";
        String ICallable.FullName => "ShipmentsAssigner.CreateIndices";
        public override Func<(QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>), QArray<QArray<Qubit>>> Body => (__in) =>
        {
            var (qubits,numStops,lenIndex,numProperties,propertyLengths) = __in;
#line 307 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var qIndices = new QArray<QArray<Qubit>>(numStops);
#line 308 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            foreach (var i in new Range(0L, (numStops - 1L)))
#line hidden
            {
#line 309 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var startIndex = (i * lenIndex);
#line 310 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var endIndex = ((startIndex + lenIndex) - 1L);
#line 312 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                qIndices[i] = qubits?.Slice(new Range(startIndex, endIndex));
            }

#line 315 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            return qIndices;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Qubit>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Qubit>>> Run(IOperationFactory __m__, QArray<Qubit> qubits, Int64 numStops, Int64 lenIndex, Int64 numProperties, QArray<Int64> propertyLengths)
        {
            return __m__.Run<CreateIndices, (QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>), QArray<QArray<Qubit>>>((qubits, numStops, lenIndex, numProperties, propertyLengths));
        }
    }

    public class Oracle : Unitary<(QArray<Qubit>,Database,Qubit)>, ICallable
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

        protected ICallable<(QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>), QArray<QArray<Qubit>>> CreateIndices
        {
            get;
            set;
        }

        protected ICallable<Database, QArray<Int64>> GetPropertyLengths
        {
            get;
            set;
        }

        protected IUnitary<(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian)> _ValidTimes
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Qubit)> UtilsCompareXIfAllZero
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> UtilsGeneralSumIntArray
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Database,Qubit), QVoid> Body => (__in) =>
        {
            var (qubits,database,ancilla) = __in;
#line 325 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numStops = database.Data.Length;
#line 326 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lenIndex = (qubits.Length / numStops);
#line 328 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var propertyLengths = GetPropertyLengths.Apply(database);
#line 329 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numProperties = propertyLengths.Length;
#line 330 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var shipmentIdLength = propertyLengths[0L];
#line 331 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var timeLength = propertyLengths[1L];
#line 332 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var coordinatesLength = propertyLengths[2L];
#line 334 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var qIndices = CreateIndices.Apply((qubits?.Copy(), numStops, lenIndex, numProperties, propertyLengths?.Copy()));
#line 336 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var targetLength = UtilsGeneralSumIntArray.Apply(propertyLengths);
#line hidden
            {
#line 338 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var (lastTime,inValid) = (Allocate.Apply(propertyLengths[1L]), Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numStops)));
#line 339 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var lastTimeBE = new Microsoft.Quantum.Canon.BigEndian(lastTime?.Copy());
#line 340 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var inValidLE = new Microsoft.Quantum.Canon.LittleEndian(inValid?.Copy());
#line 342 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                _ValidTimes.Apply((qIndices?.Copy(), database, lastTimeBE, inValidLE));
#line 344 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                UtilsCompareXIfAllZero.Apply((inValid?.Copy(), ancilla));
#line 346 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                _ValidTimes.Adjoint.Apply((qIndices?.Copy(), database, lastTimeBE, inValidLE));
#line hidden
                Release.Apply(lastTime);
#line hidden
                Release.Apply(inValid);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Database,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (qubits,database,ancilla) = __in;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var lenIndex = (qubits.Length / numStops);
#line hidden
            var propertyLengths = GetPropertyLengths.Apply(database);
#line hidden
            var numProperties = propertyLengths.Length;
#line hidden
            var shipmentIdLength = propertyLengths[0L];
#line hidden
            var timeLength = propertyLengths[1L];
#line hidden
            var coordinatesLength = propertyLengths[2L];
#line hidden
            var qIndices = CreateIndices.Apply((qubits?.Copy(), numStops, lenIndex, numProperties, propertyLengths?.Copy()));
#line hidden
            var targetLength = UtilsGeneralSumIntArray.Apply(propertyLengths);
#line hidden
            {
#line hidden
                var (lastTime,inValid) = (Allocate.Apply(propertyLengths[1L]), Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numStops)));
#line hidden
                var lastTimeBE = new Microsoft.Quantum.Canon.BigEndian(lastTime?.Copy());
#line hidden
                var inValidLE = new Microsoft.Quantum.Canon.LittleEndian(inValid?.Copy());
#line hidden
                _ValidTimes.Adjoint.Adjoint.Apply((qIndices?.Copy(), database, lastTimeBE, inValidLE));
#line hidden
                UtilsCompareXIfAllZero.Adjoint.Apply((inValid?.Copy(), ancilla));
#line hidden
                _ValidTimes.Adjoint.Apply((qIndices?.Copy(), database, lastTimeBE, inValidLE));
#line hidden
                Release.Apply(lastTime);
#line hidden
                Release.Apply(inValid);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qubits,database,ancilla)) = __in;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var lenIndex = (qubits.Length / numStops);
#line hidden
            var propertyLengths = GetPropertyLengths.Apply(database);
#line hidden
            var numProperties = propertyLengths.Length;
#line hidden
            var shipmentIdLength = propertyLengths[0L];
#line hidden
            var timeLength = propertyLengths[1L];
#line hidden
            var coordinatesLength = propertyLengths[2L];
#line hidden
            var qIndices = CreateIndices.Apply((qubits?.Copy(), numStops, lenIndex, numProperties, propertyLengths?.Copy()));
#line hidden
            var targetLength = UtilsGeneralSumIntArray.Apply(propertyLengths);
#line hidden
            {
#line hidden
                var (lastTime,inValid) = (Allocate.Apply(propertyLengths[1L]), Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numStops)));
#line hidden
                var lastTimeBE = new Microsoft.Quantum.Canon.BigEndian(lastTime?.Copy());
#line hidden
                var inValidLE = new Microsoft.Quantum.Canon.LittleEndian(inValid?.Copy());
#line hidden
                _ValidTimes.Controlled.Apply((__controlQubits__?.Copy(), (qIndices?.Copy(), database, lastTimeBE, inValidLE)));
#line hidden
                UtilsCompareXIfAllZero.Controlled.Apply((__controlQubits__?.Copy(), (inValid?.Copy(), ancilla)));
#line hidden
                _ValidTimes.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndices?.Copy(), database, lastTimeBE, inValidLE)));
#line hidden
                Release.Apply(lastTime);
#line hidden
                Release.Apply(inValid);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qubits,database,ancilla)) = __in;
#line hidden
            var numStops = database.Data.Length;
#line hidden
            var lenIndex = (qubits.Length / numStops);
#line hidden
            var propertyLengths = GetPropertyLengths.Apply(database);
#line hidden
            var numProperties = propertyLengths.Length;
#line hidden
            var shipmentIdLength = propertyLengths[0L];
#line hidden
            var timeLength = propertyLengths[1L];
#line hidden
            var coordinatesLength = propertyLengths[2L];
#line hidden
            var qIndices = CreateIndices.Apply((qubits?.Copy(), numStops, lenIndex, numProperties, propertyLengths?.Copy()));
#line hidden
            var targetLength = UtilsGeneralSumIntArray.Apply(propertyLengths);
#line hidden
            {
#line hidden
                var (lastTime,inValid) = (Allocate.Apply(propertyLengths[1L]), Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(numStops)));
#line hidden
                var lastTimeBE = new Microsoft.Quantum.Canon.BigEndian(lastTime?.Copy());
#line hidden
                var inValidLE = new Microsoft.Quantum.Canon.LittleEndian(inValid?.Copy());
#line hidden
                _ValidTimes.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndices?.Copy(), database, lastTimeBE, inValidLE)));
#line hidden
                UtilsCompareXIfAllZero.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (inValid?.Copy(), ancilla)));
#line hidden
                _ValidTimes.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qIndices?.Copy(), database, lastTimeBE, inValidLE)));
#line hidden
                Release.Apply(lastTime);
#line hidden
                Release.Apply(inValid);
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
            this.CreateIndices = this.Factory.Get<ICallable<(QArray<Qubit>,Int64,Int64,Int64,QArray<Int64>), QArray<QArray<Qubit>>>>(typeof(CreateIndices));
            this.GetPropertyLengths = this.Factory.Get<ICallable<Database, QArray<Int64>>>(typeof(GetPropertyLengths));
            this._ValidTimes = this.Factory.Get<IUnitary<(QArray<QArray<Qubit>>,Database,Microsoft.Quantum.Canon.BigEndian,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(_ValidTimes));
            this.UtilsCompareXIfAllZero = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(Utils.Compare.XIfAllZero));
            this.UtilsGeneralSumIntArray = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(Utils.General.SumIntArray));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Database,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, Database database, Qubit ancilla)
        {
            return __m__.Run<Oracle, (QArray<Qubit>,Database,Qubit), QVoid>((qubits, database, ancilla));
        }
    }

    public class OracleAugmented : Unitary<(QArray<Qubit>,Database,Qubit,Qubit)>, ICallable
    {
        public OracleAugmented(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Database,Qubit,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Database,Qubit,Qubit) data) : base(data)
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

        protected IUnitary<(QArray<Qubit>,Database,Qubit)> Oracle
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Database,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (qubits,database,ancilla,aug) = __in;
#line hidden
            {
#line 363 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var toggles = Allocate.Apply(1L);
#line 364 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var toggle = toggles[0L];
#line 366 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                Oracle.Apply((qubits?.Copy(), database, toggle));
#line 368 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(aug, toggle), ancilla));
#line 370 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                Oracle.Adjoint.Apply((qubits?.Copy(), database, toggle));
#line hidden
                Release.Apply(toggles);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Database,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (qubits,database,ancilla,aug) = __in;
#line hidden
            {
#line hidden
                var toggles = Allocate.Apply(1L);
#line hidden
                var toggle = toggles[0L];
#line hidden
                Oracle.Adjoint.Adjoint.Apply((qubits?.Copy(), database, toggle));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(aug, toggle), ancilla));
#line hidden
                Oracle.Adjoint.Apply((qubits?.Copy(), database, toggle));
#line hidden
                Release.Apply(toggles);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(qubits,database,ancilla,aug)) = __in;
#line hidden
            {
#line hidden
                var toggles = Allocate.Apply(1L);
#line hidden
                var toggle = toggles[0L];
#line hidden
                Oracle.Controlled.Apply((__controlQubits__?.Copy(), (qubits?.Copy(), database, toggle)));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(aug, toggle), ancilla)));
#line hidden
                Oracle.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qubits?.Copy(), database, toggle)));
#line hidden
                Release.Apply(toggles);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Database,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(qubits,database,ancilla,aug)) = __in;
#line hidden
            {
#line hidden
                var toggles = Allocate.Apply(1L);
#line hidden
                var toggle = toggles[0L];
#line hidden
                Oracle.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qubits?.Copy(), database, toggle)));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(aug, toggle), ancilla)));
#line hidden
                Oracle.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qubits?.Copy(), database, toggle)));
#line hidden
                Release.Apply(toggles);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Oracle = this.Factory.Get<IUnitary<(QArray<Qubit>,Database,Qubit)>>(typeof(Oracle));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Database,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, Database database, Qubit ancilla, Qubit aug)
        {
            return __m__.Run<OracleAugmented, (QArray<Qubit>,Database,Qubit,Qubit), QVoid>((qubits, database, ancilla, aug));
        }
    }

    public class StateAugmentedOracle : Unitary<(Int64,QArray<Qubit>,Database)>, ICallable
    {
        public StateAugmentedOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>,Database)>, IApplyData
        {
            public In((Int64,QArray<Qubit>,Database) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "StateAugmentedOracle";
        String ICallable.FullName => "ShipmentsAssigner.StateAugmentedOracle";
        protected ICallable MicrosoftQuantumCanonExclude
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Database,Qubit,Qubit)> OracleAugmented
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>,Database), QVoid> Body => (__in) =>
        {
            var (flagIndex,qubits,database) = __in;
#line 381 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var flag = qubits[flagIndex];
#line 382 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var stateQubits = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {flagIndex}, qubits?.Copy()));
#line 383 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            OracleAugmented.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(stateQubits), database, flag, MicrosoftQuantumCanonTail.Apply<Qubit>(stateQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Qubit>,Database), QVoid> AdjointBody => (__in) =>
        {
            var (flagIndex,qubits,database) = __in;
#line hidden
            var flag = qubits[flagIndex];
#line hidden
            var stateQubits = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {flagIndex}, qubits?.Copy()));
#line hidden
            OracleAugmented.Adjoint.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(stateQubits), database, flag, MicrosoftQuantumCanonTail.Apply<Qubit>(stateQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,Database)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(flagIndex,qubits,database)) = __in;
#line hidden
            var flag = qubits[flagIndex];
#line hidden
            var stateQubits = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {flagIndex}, qubits?.Copy()));
#line hidden
            OracleAugmented.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(stateQubits), database, flag, MicrosoftQuantumCanonTail.Apply<Qubit>(stateQubits))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,Database)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(flagIndex,qubits,database)) = __in;
#line hidden
            var flag = qubits[flagIndex];
#line hidden
            var stateQubits = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {flagIndex}, qubits?.Copy()));
#line hidden
            OracleAugmented.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(stateQubits), database, flag, MicrosoftQuantumCanonTail.Apply<Qubit>(stateQubits))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.OracleAugmented = this.Factory.Get<IUnitary<(QArray<Qubit>,Database,Qubit,Qubit)>>(typeof(OracleAugmented));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>,Database) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 flagIndex, QArray<Qubit> qubits, Database database)
        {
            return __m__.Run<StateAugmentedOracle, (Int64,QArray<Qubit>,Database), QVoid>((flagIndex, qubits, database));
        }
    }

    public class OraclePow : Unitary<(Int64,QArray<Qubit>,Database)>, ICallable
    {
        public OraclePow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>,Database)>, IApplyData
        {
            public In((Int64,QArray<Qubit>,Database) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "OraclePow";
        String ICallable.FullName => "ShipmentsAssigner.OraclePow";
        protected ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary> MicrosoftQuantumCanonAmpAmpByOracle
        {
            get;
            set;
        }

        protected IUnitary<(Int64,QArray<Qubit>,Database)> StateAugmentedOracle
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>,Database), QVoid> Body => (__in) =>
        {
            var (power,qubits,database) = __in;
#line 393 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var stateOracle = new Microsoft.Quantum.Canon.StateOracle(StateAugmentedOracle.Partial(new Func<(Int64,QArray<Qubit>), (Int64,QArray<Qubit>,Database)>((_arg1) => (_arg1.Item1, _arg1.Item2, database))));
#line 394 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            MicrosoftQuantumCanonAmpAmpByOracle.Apply((power, stateOracle, 0L)).Apply(qubits?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Qubit>,Database), QVoid> AdjointBody => (__in) =>
        {
            var (power,qubits,database) = __in;
#line hidden
            var stateOracle = new Microsoft.Quantum.Canon.StateOracle(StateAugmentedOracle.Partial(new Func<(Int64,QArray<Qubit>), (Int64,QArray<Qubit>,Database)>((_arg1) => (_arg1.Item1, _arg1.Item2, database))));
#line hidden
            MicrosoftQuantumCanonAmpAmpByOracle.Apply((power, stateOracle, 0L)).Adjoint.Apply(qubits?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,Database)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(power,qubits,database)) = __in;
#line hidden
            var stateOracle = new Microsoft.Quantum.Canon.StateOracle(StateAugmentedOracle.Partial(new Func<(Int64,QArray<Qubit>), (Int64,QArray<Qubit>,Database)>((_arg1) => (_arg1.Item1, _arg1.Item2, database))));
#line hidden
            MicrosoftQuantumCanonAmpAmpByOracle.Apply((power, stateOracle, 0L)).Controlled.Apply((__controlQubits__?.Copy(), qubits?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Qubit>,Database)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(power,qubits,database)) = __in;
#line hidden
            var stateOracle = new Microsoft.Quantum.Canon.StateOracle(StateAugmentedOracle.Partial(new Func<(Int64,QArray<Qubit>), (Int64,QArray<Qubit>,Database)>((_arg1) => (_arg1.Item1, _arg1.Item2, database))));
#line hidden
            MicrosoftQuantumCanonAmpAmpByOracle.Apply((power, stateOracle, 0L)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qubits?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOracle));
            this.StateAugmentedOracle = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>,Database)>>(typeof(StateAugmentedOracle));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>,Database) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 power, QArray<Qubit> qubits, Database database)
        {
            return __m__.Run<OraclePow, (Int64,QArray<Qubit>,Database), QVoid>((power, qubits, database));
        }
    }

    public class CountSolutions : Operation<(Double,Database), QVoid>, ICallable
    {
        public CountSolutions(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Database)>, IApplyData
        {
            public In((Double,Database) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CountSolutions";
        String ICallable.FullName => "ShipmentsAssigner.CountSolutions";
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

        protected IUnitary<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonQuantumPhaseEstimation
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

        protected IUnitary<(Int64,QArray<Qubit>,Database)> OraclePow
        {
            get;
            set;
        }

        public override Func<(Double,Database), QVoid> Body => (__in) =>
        {
            var (maxError,database) = __in;
#line 404 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var numElements = database.Data.Length;
#line 405 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var maxDbIndex = (numElements - 1L);
#line 406 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var bitsForMaxDbIndex = MicrosoftQuantumCanonBitSize.Apply(maxDbIndex);
#line 407 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            var lenT = 8L;
#line 408 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
            Message.Apply(String.Format("t: {0}", lenT));
#line hidden
            {
#line 410 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var (control,target) = (Allocate.Apply(lenT), Allocate.Apply(((bitsForMaxDbIndex * numElements) + 2L)));
#line 411 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonSwapReverseRegister.Apply(control?.Copy());
#line 412 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var controlBE = new Microsoft.Quantum.Canon.BigEndian(control?.Copy());
#line 413 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var discreteOracle = new Microsoft.Quantum.Canon.DiscreteOracle(OraclePow.Partial(new Func<(Int64,QArray<Qubit>), (Int64,QArray<Qubit>,Database)>((_arg1) => (_arg1.Item1, _arg1.Item2, database))));
#line 415 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonQFT.Apply(new Microsoft.Quantum.Canon.BigEndian(target?.Copy()));
#line 416 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                MicrosoftQuantumCanonQuantumPhaseEstimation.Apply((discreteOracle, target?.Copy(), controlBE));
#line 418 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                var fi = MicrosoftQuantumCanonMeasureIntegerBE.Apply(controlBE);
#line 419 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                Message.Apply(("fi: " + MicrosoftQuantumExtensionsConvertToStringI.Apply(fi)));
#line 421 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Boyle/ShipmentsAssigner/Operations.qs"
                ResetAll.Apply((control + target));
#line hidden
                Release.Apply(control);
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
            this.MicrosoftQuantumCanonQuantumPhaseEstimation = this.Factory.Get<IUnitary<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.QuantumPhaseEstimation));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.OraclePow = this.Factory.Get<IUnitary<(Int64,QArray<Qubit>,Database)>>(typeof(OraclePow));
        }

        public override IApplyData __dataIn((Double,Database) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double maxError, Database database)
        {
            return __m__.Run<CountSolutions, (Double,Database), QVoid>((maxError, database));
        }
    }
}