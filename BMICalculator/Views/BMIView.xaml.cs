using BMICalculator.ViewModels;

namespace BMICalculator.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}