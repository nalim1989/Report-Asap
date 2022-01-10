using System;
using System.Collections.Generic;
using ReportAsapp.View.Configuration;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace ReportAsapp
{
    public partial class NewProjectPage : ContentPage
    {
        
        private NewProjectViewModel newProjectViewModel;
        public NewProjectPage()
        {
            InitializeComponent();
            
            NavigationConfig.configure(this);

            newProjectViewModel = new NewProjectViewModel();
            BindingContext = newProjectViewModel;
        }

        protected override void OnAppearing()
        {
            newProjectViewModel.reloadData();
        }
    }
}
