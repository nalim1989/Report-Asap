using System;
using System.Collections.Generic;
using ReportAsapp.View.Configuration;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class RegisterPage : ContentPage
    {
        private RegisterViewModel registerViewModel;
        public RegisterPage()
        {
            InitializeComponent();

            NavigationConfig.configure(this);

            registerViewModel = new RegisterViewModel();
            BindingContext = registerViewModel;
        }
    }
}
