using Report_Asapp;
using Report_Asapp.Database.Model;
using Report_Asapp.Model;

namespace ReportAsapp.Logic
{
    public class CreateProjectLogic
    {
        public void saveProject(ProjectModel project)
        {
            App.Database.SaveProjectAsync(new ProjectDb(project));
        }
    }
}