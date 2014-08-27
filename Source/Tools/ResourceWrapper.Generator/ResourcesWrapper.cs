﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ResourceWrapper.Generator
{
    using System.Reflection;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ResourcesWrapper : Transformation
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("//-----------------------------------------------------------------------------\r\n" +
                    "//\r\n//\tThis code was generated by a ");
            
            #line 5 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Assembly.GetEntryAssembly().GetName().Name));
            
            #line default
            #line hidden
            this.Write(" Version ");
            
            #line 5 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Assembly.GetEntryAssembly().GetName().Version.ToString()));
            
            #line default
            #line hidden
            this.Write(".\r\n//\r\n//\tChanges to this file may cause incorrect behavior and will be lost if\r\n" +
                    "//\tthe code is regenerated.\r\n//\r\n//---------------------------------------------" +
                    "--------------------------------\r\n\r\nnamespace ");
            
            #line 12 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.NameSpace));
            
            #line default
            #line hidden
            this.Write(@" {
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;
	using System.Runtime.CompilerServices;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated.
	// To add or remove a member, edit your .ResX file then rerun MsBuild,
	// or rebuild your VS project.
	[DebuggerNonUserCodeAttribute()]
	[CompilerGeneratedAttribute()]
	");
            
            #line 30 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.IsPublic ? "public" : "internal"));
            
            #line default
            #line hidden
            this.Write(" static class ");
            
            #line 30 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            this.Write(@" {

		/// <summary>
		/// Overrides the current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture { get; set; }

		private static ");
            
            #line 39 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Pseudo ? "Pseudo" : ""));
            
            #line default
            #line hidden
            this.Write(@"ResourceManager resourceManager;

		/// <summary>
		/// Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager {
			get {
				if(resourceManager == null) {
					resourceManager = new ");
            
            #line 48 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Pseudo ? "Pseudo" : ""));
            
            #line default
            #line hidden
            this.Write("ResourceManager(\"");
            
            #line 48 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ResourceName));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 48 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            this.Write(").Assembly);\r\n\t\t\t\t}\r\n\t\t\t\treturn resourceManager;\r\n\t\t\t}\r\n\t\t}\r\n");
            
            #line 53 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
if(this.Pseudo) {
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// <summary>\r\n\t\t/// Performs pseudo localization of string resources\r\n\t\t/// " +
                    "</summary>\r\n\t\tprivate class PseudoResourceManager : ResourceManager {\r\n\t\t\tprivat" +
                    "e static Dictionary<char, char> map = new Dictionary<char, char> {\r\n\t\t\t\t{ \'a\', \'" +
                    "ä\' },\r\n\t\t\t\t{ \'b\', \'ƃ\' },\r\n\t\t\t\t{ \'c\', \'č\' },\r\n\t\t\t\t{ \'d\', \'ƌ\' },\r\n\t\t\t\t{ \'e\', \'ë\' }" +
                    ",\r\n\t\t\t\t{ \'f\', \'ƒ\' },\r\n\t\t\t\t{ \'g\', \'ğ\' },\r\n\t\t\t\t{ \'h\', \'ħ\' },\r\n\t\t\t\t{ \'i\', \'ï\' },\r\n\t" +
                    "\t\t\t{ \'j\', \'ĵ\' },\r\n\t\t\t\t{ \'k\', \'ƙ\' },\r\n\t\t\t\t{ \'l\', \'ł\' },\r\n\t\t\t\t{ \'m\', \'ɱ\' },\r\n\t\t\t\t{" +
                    " \'n\', \'ň\' },\r\n\t\t\t\t{ \'o\', \'ö\' },\r\n\t\t\t\t{ \'p\', \'þ\' },\r\n\t\t\t\t{ \'q\', \'ɋ\' },\r\n\t\t\t\t{ \'r\'" +
                    ", \'ř\' },\r\n\t\t\t\t{ \'s\', \'š\' },\r\n\t\t\t\t{ \'t\', \'ŧ\' },\r\n\t\t\t\t{ \'u\', \'ü\' },\r\n\t\t\t\t{ \'v\', \'ṽ" +
                    "\' },\r\n\t\t\t\t{ \'w\', \'ŵ\' },\r\n\t\t\t\t{ \'x\', \'ӿ\' },\r\n\t\t\t\t{ \'y\', \'ŷ\' },\r\n\t\t\t\t{ \'z\', \'ž\' }," +
                    "\r\n\t\t\t\t{ \'A\', \'Ä\' },\r\n\t\t\t\t{ \'B\', \'Ɓ\' },\r\n\t\t\t\t{ \'C\', \'Č\' },\r\n\t\t\t\t{ \'D\', \'Đ\' },\r\n\t\t" +
                    "\t\t{ \'E\', \'Ë\' },\r\n\t\t\t\t{ \'F\', \'Ƒ\' },\r\n\t\t\t\t{ \'G\', \'Ğ\' },\r\n\t\t\t\t{ \'H\', \'Ħ\' },\r\n\t\t\t\t{ " +
                    "\'I\', \'Ï\' },\r\n\t\t\t\t{ \'J\', \'Ĵ\' },\r\n\t\t\t\t{ \'K\', \'Ҟ\' },\r\n\t\t\t\t{ \'L\', \'Ł\' },\r\n\t\t\t\t{ \'M\'," +
                    " \'Ӎ\' },\r\n\t\t\t\t{ \'N\', \'Ň\' },\r\n\t\t\t\t{ \'O\', \'Ö\' },\r\n\t\t\t\t{ \'P\', \'Ҏ\' },\r\n\t\t\t\t{ \'Q\', \'Ǫ\'" +
                    " },\r\n\t\t\t\t{ \'R\', \'Ř\' },\r\n\t\t\t\t{ \'S\', \'Š\' },\r\n\t\t\t\t{ \'T\', \'Ŧ\' },\r\n\t\t\t\t{ \'U\', \'Ü\' },\r" +
                    "\n\t\t\t\t{ \'V\', \'Ṽ\' },\r\n\t\t\t\t{ \'W\', \'Ŵ\' },\r\n\t\t\t\t{ \'X\', \'Ӿ\' },\r\n\t\t\t\t{ \'Y\', \'Ŷ\' },\r\n\t\t\t" +
                    "\t{ \'Z\', \'Ž\' },\r\n\t\t\t};\r\n\r\n\t\t\tprivate Dictionary<string, string> resources = new D" +
                    "ictionary<string, string>();\r\n\r\n\t\t\tpublic PseudoResourceManager(string baseName," +
                    " Assembly assembly) : base(baseName, assembly) {\r\n\t\t\t}\r\n\r\n\t\t\tpublic override str" +
                    "ing GetString(string name, CultureInfo culture) {\r\n\t\t\t\tif(culture == null) {\r\n\t\t" +
                    "\t\t\treturn this.Pseudo(name);\r\n\t\t\t\t}\r\n\t\t\t\treturn base.GetString(name, culture);\r\n" +
                    "\t\t\t}\r\n\r\n\t\t\tpublic string GetBaseString(string name, CultureInfo culture) {\r\n\t\t\t\t" +
                    "return base.GetString(name, culture);\r\n\t\t\t}\r\n\r\n\t\t\tpublic string GetBaseString(st" +
                    "ring[] values, string name, CultureInfo culture) {\r\n\t\t\t\tstring text;\r\n\t\t\t\tif(!th" +
                    "is.resources.TryGetValue(name, out text)) {\r\n\t\t\t\t\tRandom random = new Random();\r" +
                    "\n\t\t\t\t\tthis.resources[name] = text = values[random.Next(values.Length)];\r\n\t\t\t\t\tDe" +
                    "bug.WriteLine(\"Pseudo Localizing {0} to value {1}\", name, text);\r\n\t\t\t\t}\r\n\t\t\t\tret" +
                    "urn text;\r\n\t\t\t}\r\n\r\n\t\t\tprivate string Pseudo(string name) {\r\n\t\t\t\tstring text;\r\n\t\t" +
                    "\t\tif(!this.resources.TryGetValue(name, out text)) {\r\n\t\t\t\t\tthis.resources[name] =" +
                    " text = this.PseudoLocalize(base.GetString(name, null));\r\n\t\t\t\t}\r\n\t\t\t\treturn text" +
                    ";\r\n\t\t\t}\r\n\r\n\t\t\tprivate string PseudoLocalize(string text) {\r\n\t\t\t\tif(!string.IsNul" +
                    "lOrEmpty(text)) {\r\n\t\t\t\t\tchar[] result = new char[text.Length];\r\n\t\t\t\t\tfor(int i =" +
                    " 0; i < result.Length; i++) {\r\n\t\t\t\t\t\tchar c;\r\n\t\t\t\t\t\tif(map.TryGetValue(text[i], " +
                    "out c)) {\r\n\t\t\t\t\t\t\tresult[i] = c;\r\n\t\t\t\t\t\t} else {\r\n\t\t\t\t\t\t\tresult[i] = text[i];\r\n\t" +
                    "\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t\treturn \"[===\" + new string(result) + \"===]\";\r\n\t\t\t\t}\r\n\t\t\t\tre" +
                    "turn text;\r\n\t\t\t}\r\n\t\t}\r\n");
            
            #line 164 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
}
            
            #line default
            #line hidden
            
            #line 165 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
foreach(ResourceItem item in this.Items) {
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// <summary>\r\n\t\t/// Looks up a localized string similar to ");
            
            #line 168 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Comment));
            
            #line default
            #line hidden
            this.Write(".\r\n\t\t/// </summary>\r\n");
            
            #line 170 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
	if(item.Parameters != null) {
            
            #line default
            #line hidden
            this.Write(" \t\tpublic static string ");
            
            #line 171 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 171 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.ParametersDeclaration));
            
            #line default
            #line hidden
            this.Write(") {\r\n\t\t\treturn string.Format(Culture, ");
            
            #line 172 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.GetStringExpression(this.Pseudo)));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 172 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("\", Culture), ");
            
            #line 172 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.ParametersInvocation));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n");
            
            #line 174 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
	} else if(item.Type == "string") {
            
            #line default
            #line hidden
            this.Write(" \t\tpublic static string ");
            
            #line 175 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write(" {\r\n\t\t\tget { return ");
            
            #line 176 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.GetStringExpression(this.Pseudo)));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 176 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("\", Culture); }\r\n\t\t}\r\n");
            
            #line 178 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
	} else {
            
            #line default
            #line hidden
            this.Write(" \t\tpublic static ");
            
            #line 179 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 179 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write(" {\r\n\t\t\tget { return (");
            
            #line 180 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Type));
            
            #line default
            #line hidden
            this.Write(")ResourceManager.GetObject(\"");
            
            #line 180 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("\", Culture); }\r\n\t\t}\r\n");
            
            #line 182 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
	}
            
            #line default
            #line hidden
            
            #line 183 "C:\Projects\LogicCircuit\Fusion\Work\Source\Tools\ResourceWrapper.Generator\ResourcesWrapper.tt"
}
            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
