using ReportAsapp.View.Configuration;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            NavigationConfig.configure(this);
        }
    }
}
