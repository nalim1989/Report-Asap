using System;
using Report_Asapp.Database.Model;

namespace Report_Asapp.Model
{
    public class ProjectModel
    {
        public ProjectModel(){}

        public string ProjectName { get; set; }
        public string Investor { get; set; }
        public string Contractor { get; set; }
        public string Supervisor { get; set; }

        public ProjectModel(ProjectDb projectDb)
        {
            this.ProjectName = projectDb.ProjectName;
            this.Investor = projectDb.Investor;
            this.Contractor = projectDb.Contractor;
            this.Supervisor = projectDb.Supervisor;
        }
    }
}