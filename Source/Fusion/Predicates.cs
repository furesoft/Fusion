﻿using System.Diagnostics;
using System.Linq;

namespace Fusion {
	public class Predicates {
		public Assembler Assembler { get; }

		public FusionParserListener Listener { get; }

		public Predicates(Assembler assembler, FusionParserListener listener) {
			Assembler = assembler;
			Listener = listener;
		}

		private int ParamCount(string name) {
			MacroDefinition? parsingMacro = this.Listener.CurrentMacro;
			Debug.Assert(parsingMacro != null);
			if(!parsingMacro.Parameters.Any((Token token) => token.Value == name) && !parsingMacro.Labels.Any((Token token) => token.Value == name) && Assembler.Macro.TryGetValue(name, out var macro)) {
				return macro.Parameters.Count;
			}
			return -1;
		}

		public bool IsMacro0(string name) {
			return 0 == this.ParamCount(name);
		}

		public bool IsMacroN(string name) {
			return 0 < this.ParamCount(name);
		}

		public bool IsNotMacro(string name) {
			return this.ParamCount(name) < 0;
		}
	}
}
