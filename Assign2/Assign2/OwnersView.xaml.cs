using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assign2
{
    public partial class OwnersView : ContentPage
    {
        public OwnersView()
        {
            InitializeComponent();
            BindingContext = this;
            loadOwners();
        }

        private async void loadOwners()
        {
            var owners = await App.Owners.Value.GetAsync();
            Owners.ItemsSource = owners;
        }
    }
}

