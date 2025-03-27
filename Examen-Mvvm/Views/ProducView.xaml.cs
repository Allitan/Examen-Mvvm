namespace Examen_Mvvm.Views;

public partial class ProducView : ContentPage
{
    ProducViewModel viewModel = new ProducViewModel();
    public ProducView()
	{
		InitializeComponent();
        viewModel = new ProducViewModel();
        this.BindingContext = viewModel;
    }
}