using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views;

public partial class ProducView : ContentPage
{
    ProductViewModel viewModel;
    public ProducView()
	{
		InitializeComponent();
        viewModel = new ProductViewModel();
        this.BindingContext = viewModel;
    }
}