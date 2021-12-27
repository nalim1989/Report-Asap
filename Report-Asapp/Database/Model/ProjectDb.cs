using Report_Asapp.Model;
using SQLite;

namespace Report_Asapp.Database.Model
{
    public class ProjectDb
    {
         [PrimaryKey, AutoIncrement]
          public int ID { get; set; }
          public string ProjectName { get; set; }
          public string Investor { get; set; }
          public string Contractor { get; set; }
          public string Supervisor { get; set; }

          public ProjectDb()
          {
          }

          public ProjectDb(ProjectModel project)
          {
              this.ProjectName = project.ProjectName;
              this.Investor = project.Investor;
              this.Supervisor = project.Supervisor;
              this.Contractor = project.Contractor;
          }
    }
}