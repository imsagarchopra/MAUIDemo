using WeatherForecastApp.Views;

namespace WeatherForecastApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherView();
        }
    }
}