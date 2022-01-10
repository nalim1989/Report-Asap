using System.Collections.Generic;
using Report_Asapp;
using Report_Asapp.Database.Model;
using Report_Asapp.Model;

namespace ReportAsapp.Logic
{
    public class ProjectLogic
    {
        public void saveProject(ProjectModel project)
        {
            App.Database.SaveProjectAsync(new ProjectDb(project));
        }

        public List<ProjectModel> readAllProjects()
        {
            List<ProjectDb> projects = App.Database.GetProjectsAsync().Result;

            List<ProjectModel> projectModels = new List<ProjectModel>();

            foreach(ProjectDb prj in projects)
            {
                projectModels.Add(new ProjectModel(prj));
            }

            return projectModels;
        }
    }
}