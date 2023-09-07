using ProsperDaily.ViewModels;

namespace ProsperDaily.Views;

public partial class StatisticsPage : ContentPage
{
	public StatisticsPage()
	{
		InitializeComponent();
		  BindingContext = new StatisticsViewModel();
	}
     protected override void OnAppearing()
     {
          var vm = (StatisticsViewModel)BindingContext;
          vm.GetTransactionsSummary();
     }
}