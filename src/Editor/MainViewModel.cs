using System.ComponentModel;
using Scripting;

namespace Editor
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = (sender, args) => { };

		IScriptEvaluator evaluator;

		public MainViewModel ()
		{
			evaluator = new ScriptEvaluator ();
		}

		public string Source { get; set; }

		public string Output { get; set; }

		void OnPropertyChanged(string propertyName)
		{
			PropertyChanged (this, new PropertyChangedEventArgs (propertyName));

			if (propertyName == nameof (Source))
				Output = evaluator.Evaluate(Source);
		}
	}
}
