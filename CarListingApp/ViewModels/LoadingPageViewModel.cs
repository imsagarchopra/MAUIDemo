using CarListingApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingApp.ViewModels
{
    public partial class LoadingPageViewModel : BaseViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }

        private async Task CheckUserLoginDetails()
        {
            //Retrieve token from Internal storage
            var token = await SecureStorage.GetAsync("Token");

            if(string.IsNullOrWhiteSpace(token))
            {
                await GoToLoginPage();
            }
            
            //Evaluate token and decide if it is valid


        }

        private async Task GoToLoginPage()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        private async Task GoToMainPage()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }
    }
}
