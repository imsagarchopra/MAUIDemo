using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingApp.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        string username;

        [ObservableProperty]
        string password;

        [RelayCommand]
        async Task Login()
        {
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await Shell.Current.DisplayAlert("Invalid Attempt", "Invalid Username or Password", "OK");
                this.Password = string.Empty;
            }
            else
            {
                //Call API to attempt login
                var loginSuccessful = true;

                if(loginSuccessful)
                {
                    //Display welcome message

                    //Build a menu on the fly based on user role

                    //Navigate to App Main Page.
                }

                await DisplayLoginError();
            }
        }

        async Task DisplayLoginError()
        {
            await Shell.Current.DisplayAlert("Invalid Attempt", "Invalid Username or Password", "OK");
            this.Password = string.Empty;
        }
    }
}
