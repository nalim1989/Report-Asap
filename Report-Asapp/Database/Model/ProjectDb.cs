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
    }
}