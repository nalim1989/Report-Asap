using System;
using System.Collections.Generic;
using ReportAsapp.View.Configuration;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class CreateProjectPage : ContentPage
    {
        
        private CreateProjectViewModel createProjectViewModel;
        public CreateProjectPage()
        {
            InitializeComponent();
            
            NavigationConfig.configure(this);

            createProjectViewModel = new CreateProjectViewModel();
            BindingContext = createProjectViewModel;
        }
    }
}
