using System.Collections.Generic;
using System.Windows.Input;
using Report_Asapp.Model;
using ReportAsapp.Logic;
using ReportAsapp.View;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class NewProjectViewModel
    {
        public ICommand CreateProjectCommand { private set; get; }
        public List<ProjectModel> AllProjects { private set; get; }
        private ProjectLogic _projectLogic;
        
        public NewProjectViewModel()
        {
            CreateProjectCommand = new Command(() => CreateProject());
            this._projectLogic = new ProjectLogic();
        }

        private async void CreateProject()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CreateProjectPage(this._projectLogic));
        }

        public void reloadData()
        {
            AllProjects = _projectLogic.readAllProjects();
        }
    }
}