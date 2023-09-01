using CarListingApp.Models;
using CarListingApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarListingApp.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        private readonly CarApiService _carApiService;
        public LoginPageViewModel(CarApiService carApiService)
        {
            _carApiService = carApiService;
        }
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
                var loginModel = new LoginModel(username, password);

                var response = await _carApiService.Login(loginModel);

                //Display welcome message
                await DisplayLoginMessage(_carApiService.StatusMessage);

                if(!string.IsNullOrEmpty(response.Token))
                {

                    //Store token in secure storage
                    await SecureStorage.SetAsync("Token", response.Token);

                    //Build a menu on the fly based on user role                
                    var jsonToken = new JwtSecurityTokenHandler().ReadToken(response.Token) as JwtSecurityToken;

                    var role = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Role))?.Value;

                    var userInfo = new UserInfo()
                    {
                        Username = Username,
                        Role = role
                    };

                    //if(Preferences.ContainsKey(nameof(UserInfo)))
                    //{
                    //    Preferences.Remove(nameof(UserInfo));
                    //}

                    App.UserInfo = userInfo;

                    //Navigate to App Main Page.
                    await Shell.Current.GoToAsync(nameof(MainPage));
                }
                else
                {
                    await DisplayLoginMessage("Invalid Login Attempt");
                }             
            }
        }

        async Task DisplayLoginMessage(string message)
        {
            await Shell.Current.DisplayAlert("Login Attempt Result", message, "OK");
            this.Password = string.Empty;
        }
    }
}
