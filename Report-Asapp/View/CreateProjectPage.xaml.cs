using System;
using System.Collections.Generic;
using ReportAsapp.Logic;
using ReportAsapp.View.Configuration;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class CreateProjectPage : ContentPage
    {
        
        private CreateProjectViewModel createProjectViewModel;
        public CreateProjectPage(ProjectLogic projectLogic)
        {
            InitializeComponent();
            
            NavigationConfig.configure(this);

            createProjectViewModel = new CreateProjectViewModel(projectLogic);
            BindingContext = createProjectViewModel;
        }
    }
}
