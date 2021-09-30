using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace Report_Asapp
{
    public partial class WelcomePage : ContentPage
    {
        private WelcomeViewModel welcomeViewModel;
        public WelcomePage()
        {
            welcomeViewModel = new WelcomeViewModel();
            InitializeComponent();
            BindingContext = welcomeViewModel;
        }
    }
}
