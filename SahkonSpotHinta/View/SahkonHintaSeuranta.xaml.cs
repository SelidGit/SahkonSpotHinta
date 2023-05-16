using SahkonSpotHinta.ViewModel;

namespace SahkonSpotHinta;

public partial class SahkonHintaSeuranta : ContentPage
{
	public SahkonHintaSeuranta(PriceViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}