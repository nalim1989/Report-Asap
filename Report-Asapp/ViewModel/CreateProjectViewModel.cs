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

        private CreateProjectLogic _logic;

        public CreateProjectViewModel()
        {
            this.ProjectModel = new ProjectModel();
            CreateProjectCommand = new Command(() => CreateProject());
            _logic = new CreateProjectLogic();
        }
        
        private async void CreateProject()
        {
            _logic.saveProject(this.ProjectModel);
        }
    }
}