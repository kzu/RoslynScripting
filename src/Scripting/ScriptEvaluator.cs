using System;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Scripting
{
	public class ScriptEvaluator : IScriptEvaluator
	{
		public string Evaluate (string source)
		{
			try {
				var sb = new StringBuilder();
				var sw = new StringWriter(sb);
				Console.SetOut (sw);
				var script = CSharpScript.Create(source,
					ScriptOptions.Default
						.WithImports(
							"System",
							// NOTE: makes Write/WriteLine available without writing Console. 
							"System.Console")
					);

				script.RunAsync ().Wait ();
				var compilation = script.GetCompilation();

				sw.Flush ();
				return sb.ToString ();
			} catch (CompilationErrorException e) {
				return string.Join (Environment.NewLine, e.Diagnostics);
			}
		}
	}
}
