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
                    public Task<List<ProjectDb>> GetPeopleAsync()
                    {
                        return _database.Table<ProjectDb>().ToListAsync();
                    }
        
                    // Save project
                    public Task<int> SavePersonAsync(ProjectDb project)
                    {
                        return _database.InsertAsync(project);
                    }
        
                    // Delete project
                    public Task<int> DeletePersonAsync(ProjectDb project)
                    {
                        return _database.DeleteAsync(project);
                    }
        
                    // Save project
                    public Task<int> UpdatePersonAsync(ProjectDb project)
                    {
                        return _database.UpdateAsync(project);
                    }
    }
}