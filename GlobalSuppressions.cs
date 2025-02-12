// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

// Main() suppressions for Program.cs only
[assembly: SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "<Pending>", Scope = "member", Target = "~M:GalacticWarriors.Program.Main")]
[assembly: SuppressMessage("Style", "IDE0008:Use explicit type", Justification = "<Pending>", Scope = "member", Target = "~M:GalacticWarriors.Program.Main")]

// GLOBAL suppressions for the entire project
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", 
		Justification = "Tim: I prefer to start accessors with lowercase letters to distinguish them from functions, and encourage more variable-like treatment.")]
[assembly: SuppressMessage("Style", "IDE0032:Use auto property", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0025:Use expression body for properties", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0011:Add braces", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0130:Namespace does not match folder structure", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0003:Remove qualification", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0048:Add parentheses for clarity", Justification = "<Pending>")]
[assembly: SuppressMessage("Style", "IDE0024:Use block body for operators", 
		Justification = "Tim: Very simple operators is fine. Use body block for anything that involves math of more than 2 variables.")]
