using System;
using System.Windows.Input;
using Report_Asapp;
using ReportAsapp.View;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    //https://www.c-sharpcorner.com/article/login-form-in-xamarin-forms-for-biggner-using-mvvm-pattern/
    public class WelcomeViewModel
    {

        public ICommand LoginCommand { private set; get; }
        public ICommand RegisterCommand { private set; get; }

        public WelcomeViewModel()
        {
            LoginCommand = new Command(() => Login());
            RegisterCommand = new Command(() => Register());
        }

        private async void Login()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private async void Register()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}