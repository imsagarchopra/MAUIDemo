using Calculator.ViewModels;

namespace Calculator.Views;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		this.BindingContext = new CalcViewModel();
	}
}