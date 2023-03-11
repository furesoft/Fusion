﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Antlr4.Runtime;

namespace Fusion {
	public class Assembler {

		//private const string BinaryName = "binary";
		private const string MainName = "main";
		//private const string AtomicName = "atomic";
		//private const string MacroName = "macro";
		public const string PrintName = "print";
		public const string ErrorName = "error";
		public const string IfName = "if";
		public const string ElseName = "else";

		private readonly DateTime started = DateTime.Now;

		public TextWriter ErrorOutput { get; }
		public TextWriter StandardOutput { get; }

		private readonly BinaryWriter writer;

		public int ErrorCount { get; private set; }
		private bool fatalError;
		public bool CanContinue { get { return !this.fatalError && this.ErrorCount < 10; } }

		private string? root;

		private IEnumerable<string> searchPath;
		public IEnumerable<string> SearchPath { 
			get {
				if(this.root != null) {
					yield return this.root;
				} else {
					yield return Environment.CurrentDirectory;
				}
				foreach(string item in searchPath) {
					yield return item;
				}
			}
		}
		
		public Dictionary<string, int> Files { get; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		public Dictionary<string, MacroDefinition> Macro { get; } = new Dictionary<string, MacroDefinition>();

		public BinaryFormatter BinaryFormatter { get; private set; }

		public Assembler(TextWriter errorOutput, TextWriter standardOutput, BinaryWriter writer, IEnumerable<string> searchPath) {
			this.ErrorOutput = errorOutput;
			this.StandardOutput = standardOutput;
			this.writer = writer;
			this.searchPath = searchPath;
			this.ErrorCount = 0;
			this.BinaryFormatter = new BinaryFormatter8(this.writer);
		}

		public void Error(string message) {
			this.ErrorCount++;
			this.ErrorOutput.WriteLine(message);
		}

		public void FatalError(string message) {
			this.fatalError = true;
			this.Error(message);
		}

		public void Compile(string file) {
			this.root = Path.GetDirectoryName(file);
			if(this.root != null) {
				this.root = this.root.Trim();
				if(this.root.Length == 0) {
					this.root = null;
				}
			}
			this.FirstPassParse(file);
			if(0 < this.ErrorCount) return;
			this.SecondPassParse();
			if(0 < this.ErrorCount) return;
			this.Expand();
		}

		private void Expand() {
			MacroDefinition? main = null;
			if(!this.Macro.TryGetValue(Assembler.MainName, out main)) {
				this.Error(Resource.MainMissing);
				return;
			}
			if(0 < main.Parameters.Count) {
				this.Error(Resource.MainPararameters);
				return;
			}
			Context context = new Context(this, main);
			Value value = main.Body.Evaluate(context, 0);
			if(0 < this.ErrorCount) {
				return;
			}
			ListValue? listValue = value as ListValue;
			Debug.Assert(listValue != null);
			listValue.ResolveLabels(context);
			if(this.ErrorCount == 0) {
				listValue.WriteValue(this);
				if(this.ErrorCount == 0) {
					main.Body.WriteListing(this, listValue, 0);
				}
			}
		}

		public void FirstPassParse(string file) {
			FirstPassParser? parser = this.Parser<FirstPassParser>(file, 1);
			if(parser != null) {
				FirstPassParser.FusionProgramContext programContext = parser.fusionProgram();
				if(this.ErrorCount == 0) {
					FirstPass firstPass = new FirstPass(this, file);
					firstPass.VisitFusionProgram(programContext);
				}
			}
		}

		private void SecondPassParse() {
			FusionParserListener listener = new FusionParserListener(this);
			Predicates predicates = new Predicates(this, listener);
			foreach(string file in this.Files.Keys) {
				if(!this.CanContinue) {
					break;
				}
				FusionParser? parser = this.Parser<FusionParser>(file, 2);
				if(parser != null) {
					parser.AddParseListener(listener);
					parser.predicates = predicates;
					FusionParser.FusionProgramContext programContext = parser.fusionProgram();
					if(this.ErrorCount == 0) {
						#if DEBUG
							Debug.WriteLine("Second pass parse tree:");
							Debug.WriteLine(ParseTreePrinter.Text(programContext));
						#endif
						SecondPass secondPass = new SecondPass(this, file);
						secondPass.VisitFusionProgram(programContext);
					}
				}
			}
		}

		public void SetBinaryType(int binaryType) {
			switch(binaryType) {
			case 8:
				this.BinaryFormatter = new BinaryFormatter8(this.writer);
				break;
			case 16:
				this.BinaryFormatter = new BinaryFormatter16(this.writer);
				break;
			case 32:
				this.BinaryFormatter = new BinaryFormatter32(this.writer);
				break;
			default:
				throw new InvalidOperationException();
			}
		}

		private P? Parser<P>(string file, int currentPass) where P : Parser {
			if(this.started < File.GetLastWriteTime(file)) {
				this.FatalError(Resource.FileChanged(file));
				return null;
			}
			if(!this.Files.TryGetValue(file, out var pass) || pass < currentPass) {
				this.Files[file] = currentPass;
				FusionErrorListner errorListner = new FusionErrorListner(this, file);
				using TextReader reader = new StreamReader(file);
				FusionLexer fusionLexer = new FusionLexer(new AntlrInputStream(reader));
				fusionLexer.RemoveErrorListeners();
				fusionLexer.AddErrorListener(errorListner);
				CommonTokenStream tokens = new CommonTokenStream(fusionLexer);
				P? parser = (P?)Activator.CreateInstance(typeof(P), tokens);
				Debug.Assert(parser != null);
				parser.RemoveErrorListeners();
				parser.AddErrorListener(errorListner);
				return parser;
			}
			return null;
		}
	}
}
