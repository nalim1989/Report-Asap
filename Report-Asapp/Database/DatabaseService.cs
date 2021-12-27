using System.Collections.Generic;
using System.Threading.Tasks;
using Report_Asapp.Database.Model;
using SQLite;

namespace Report_Asapp.Database
{
    public class DatabaseService
    {
         readonly SQLiteAsyncConnection _database;
        
         public DatabaseService(string dbPath)
         {
            //Establishing the conection
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ProjectDb>().Wait();
         }
                        
                    // Show the project
                    public Task<List<ProjectDb>> GetProjectsAsync()
                    {
                        return _database.Table<ProjectDb>().ToListAsync();
                    }
        
                    // Save project
                    public Task<int> SaveProjectAsync(ProjectDb project)
                    {
                        return _database.InsertAsync(project);
                    }
        
                    // Delete project
                    public Task<int> DeleteProjectAsync(ProjectDb project)
                    {
                        return _database.DeleteAsync(project);
                    }
        
                    // Save project
                    public Task<int> UpdateProjectAsync(ProjectDb project)
                    {
                        return _database.UpdateAsync(project);
                    }
    }
}