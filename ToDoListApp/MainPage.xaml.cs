using ToDoListApp.ViewModels;

namespace ToDoListApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}	
}

