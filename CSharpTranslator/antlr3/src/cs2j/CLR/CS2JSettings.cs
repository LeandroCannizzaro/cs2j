using System;
using System.Collections.Generic;
using RusticiSoftware.Translator.Utils;
using System.IO;
namespace RusticiSoftware.Translator.CSharp
{
	public class CS2JSettings
	{
		
		public bool DisplayTokens { get; set; }

        // dump parse trees to stdout
        public bool DumpCSharp { get; set; }
        public bool DumpJavaSyntax { get; set; }
        public bool DumpJava { get; set; }

        public bool DumpXmls { get; set; }
        public bool DumpEnums { get; set; }
        public string OutDir { get; set; }
        public string CheatDir { get; set; }
        public IList<string> NetRoot { get; set; }
        public IList<string> ExNetRoot { get; set; }
        public IList<string> AppRoot { get; set; }
        public IList<string> ExAppRoot { get; set; }
        public IList<string> Exclude { get; set; }
        public IList<string> MacroDefines { get; set; }
        public string XmlDir { get; set; }
		public string EnumDir { get; set; }
        public int Verbosity { get; set; }

        public int DebugLevel { get; set; }

        public bool Warnings { get; set; }

		public CS2JSettings ()
		{
		
			DisplayTokens = false;
        
			// dump parse trees to stdout
	        DumpCSharp = false;
	        DumpJavaSyntax = false;
	        DumpJava = false;
	
	        DumpXmls = false;
	        DumpEnums = false;
	        OutDir = Directory.GetCurrentDirectory();
	        CheatDir = "";
	        NetRoot = new List<string>();
	        ExNetRoot = new List<string>();
	        AppRoot = new List<string>();
	        ExAppRoot = new List<string>();
	        Exclude = new List<string>();
	        MacroDefines = new List<string>();
	        XmlDir = Path.Combine(Directory.GetCurrentDirectory(), "tmpXMLs");
			EnumDir = Path.Combine(Directory.GetCurrentDirectory(), "enums");
	        Verbosity = 0;		
	        DebugLevel = 0;		
	        Warnings = false;		
		}
	}
}
