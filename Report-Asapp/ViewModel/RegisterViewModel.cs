using System;
using System.Windows.Input;
using ReportAsapp.View;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class RegisterViewModel
    {
  
        public ICommand RegisterCommand { private set; get; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(() => Register());
        }

        private async void Register()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InventoryPage());
        }
    }
}
