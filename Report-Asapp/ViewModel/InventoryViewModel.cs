using System.Windows.Input;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class InventoryViewModel
    {
        public ICommand NewProjectCommand { private set; get; }

        public InventoryViewModel()
        {
            NewProjectCommand = new Command(() => NewProject());
        }

        private async void NewProject()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new NewProjectPage());
        }
    }
}