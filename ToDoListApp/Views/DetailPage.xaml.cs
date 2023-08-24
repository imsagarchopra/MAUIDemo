using ToDoListApp.ViewModels;

namespace ToDoListApp.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}