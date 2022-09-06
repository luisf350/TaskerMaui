using TaskerMaui.ViewModels;

namespace TaskerMaui.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}