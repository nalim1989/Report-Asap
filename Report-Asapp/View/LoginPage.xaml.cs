using ReportAsapp.View.Configuration;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel loginViewModel;
        public LoginPage()
        {
            InitializeComponent();

            NavigationConfig.configure(this);

            loginViewModel = new LoginViewModel();
            BindingContext = loginViewModel;
        }
    }
}
