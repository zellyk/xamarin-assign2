using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assign2
{
    public partial class VetList : ContentPage
    {
        public VetList()
        {
            InitializeComponent();
            BindingContext = this;
            loadVets();
        }

        private async void loadVets()
        {
            var vets = await App.Vets.Value.GetAsync();
            Vets.ItemsSource = vets;
        }
    }
}

