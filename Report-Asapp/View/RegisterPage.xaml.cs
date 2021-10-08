using System;
using System.Collections.Generic;
using ReportAsapp.View.Configuration;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            NavigationConfig.configure(this);
        }
    }
}
