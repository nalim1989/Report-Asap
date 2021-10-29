using System;
using System.Windows.Input;
using ReportAsapp.Logic;
using ReportAsapp.View;
using ReportAsapp.ViewModel.Prototype;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class LoginViewModel: ILoginViewModel
    {

        public ICommand LoginCommand { private set; get; }

        private LogicLogic loginLogic;

        public LoginViewModel()
        {
            LoginCommand = new Command(() => LoginClick());
            loginLogic = new LogicLogic(this);
        }

        private void LoginClick()
        {
            loginLogic.Login();
        }

        public void Login()
        {
             Application.Current.MainPage = new NavigationPage(new InventoryPage());
        }

    }
}
