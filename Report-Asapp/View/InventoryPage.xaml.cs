using System;
using System.Collections.Generic;
using ReportAsapp.View.Configuration;
using ReportAsapp.ViewModel;
using Xamarin.Forms;

namespace ReportAsapp.View
{
    public partial class InventoryPage : ContentPage
    {
        private InventoryViewModel inventoryViewModel;
        public InventoryPage()
        {
            InitializeComponent();
            
            NavigationConfig.configure(this);
            
            inventoryViewModel = new InventoryViewModel();
            BindingContext = inventoryViewModel;
        }
    }
}
