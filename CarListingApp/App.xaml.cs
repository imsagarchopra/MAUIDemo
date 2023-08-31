using CarListingApp.Services;

namespace CarListingApp
{
    public partial class App : Application
    {
        public static CarDatabaseService CarDatabaseService { get; private set; }
        public App(CarDatabaseService carDatabaseService)
        {
            InitializeComponent();

            MainPage = new AppShell();
            CarDatabaseService = carDatabaseService; 
        }
    }
}