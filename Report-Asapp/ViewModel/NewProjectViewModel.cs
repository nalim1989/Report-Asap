using System.Windows.Input;
using ReportAsapp.View;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class NewProjectViewModel
    {
        public ICommand CreateProjectCommand { private set; get; }

        public NewProjectViewModel()
        {
            CreateProjectCommand = new Command(() => CreateProject());
        }

        private async void CreateProject()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateProjectPage());
        }
    }
}