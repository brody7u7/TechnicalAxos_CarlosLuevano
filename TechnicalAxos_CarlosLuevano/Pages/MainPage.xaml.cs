namespace TechnicalAxos_CarlosLuevano.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(ViewModels.MainViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}