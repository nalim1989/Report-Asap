using System;
using ReportAsapp.ViewModel;
using ReportAsapp.ViewModel.Prototype;

namespace ReportAsapp.Logic
{
    public class LogicLogic
    {
        private ILoginViewModel loginViewModel;

        public LogicLogic(ILoginViewModel loginViewModel)
        {
            this.loginViewModel = loginViewModel;
        }

        public void Login()
        {
            loginViewModel.Login();
        }
    }
}
