using WeatherForecastApp.ViewModels;

namespace WeatherForecastApp.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
        BindingContext = new WeatherViewModel();
    }
}