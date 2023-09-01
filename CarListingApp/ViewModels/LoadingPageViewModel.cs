using CarListingApp.Views;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
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
            else
            {
                //Evaluate token and decide if it is valid
                var jsonToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;

                if(jsonToken.ValidTo < DateTime.UtcNow)
                {
                    SecureStorage.Remove("Token");
                    await GoToLoginPage();
                }
                else
                {
                    await GoToMainPage();
                }
            }



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
