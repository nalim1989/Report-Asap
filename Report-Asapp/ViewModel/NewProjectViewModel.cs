using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Report_Asapp.Common;
using Report_Asapp.Database.Model;
using Report_Asapp.Model;
using ReportAsapp.Logic;
using ReportAsapp.View;
using Xamarin.Forms;

namespace ReportAsapp.ViewModel
{
    public class NewProjectViewModel: BaseViewModel
    {
        public ICommand CreateProjectCommand { private set; get; }
        private ObservableCollection<ProjectModel> allProjects;
        public ObservableCollection<ProjectModel> AllProjects 
        {
            get { return allProjects; }
            set { this.ChangeAndNotify(ref this.allProjects, value); }
        } 
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
            AllProjects = new ObservableCollection<ProjectModel>(_projectLogic.readAllProjects());
        }
    }
}