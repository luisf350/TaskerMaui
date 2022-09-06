using TaskerMaui.Views;

namespace TaskerMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainView();
	}
}
