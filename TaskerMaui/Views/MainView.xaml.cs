using TaskerMaui.ViewModels;

namespace TaskerMaui.Views;

public partial class MainView : ContentPage
{
	private MainViewModel _viewModel = new MainViewModel();
	public MainView()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}

	private void chkCompleted_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		_viewModel.UpdateData();

    }
}