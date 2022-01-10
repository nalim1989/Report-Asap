using System.Windows.Input;
using Report_Asapp.Model;
using ReportAsapp.Logic;
using ReportAsapp.View;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class CreateProjectViewModel
    {
        public ProjectModel ProjectModel { get; set; }
        public ICommand CreateProjectCommand { private set; get; }

        private ProjectLogic _logic;

        public CreateProjectViewModel(ProjectLogic projectLogic)
        {
            this.ProjectModel = new ProjectModel();
            CreateProjectCommand = new Command(() => CreateProject());
            _logic = projectLogic;
        }
        
        private async void CreateProject()
        {
            _logic.saveProject(this.ProjectModel);
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}