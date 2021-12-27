using System;
using Report_Asapp.Database;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace Report_Asapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        
        static DatabaseService database;
 
        public static DatabaseService Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseService(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ReportsAppDb.db3"));
                }
                return database;
            }
        }
    }
}
