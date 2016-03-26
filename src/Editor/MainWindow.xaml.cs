using System.Windows;

namespace Editor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow ()
		{
			InitializeComponent ();
			DataContext = new MainViewModel ();
			Loaded += (sender, args) => 
				((MainViewModel)DataContext).Source = "Console.WriteLine(\"Hello World\");";
		}
	}
}
