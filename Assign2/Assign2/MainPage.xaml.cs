using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assign2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void VetRegister(object sender, EventArgs e) => await Navigation.PushAsync(new VetRegister());

        private async void VetList(System.Object sender, System.EventArgs e) => await Navigation.PushAsync(new VetList());

        private async void Logout(object sender, EventArgs e) => await Navigation.PopToRootAsync();

        private async void PetRegister(System.Object sender, System.EventArgs e) => await Navigation.PushAsync(new PetRegister());

        private async void PetDisplay(System.Object sender, System.EventArgs e) => await Navigation.PushAsync(new PetList());

        private async void OwnersView(System.Object sender, System.EventArgs e) => await Navigation.PushAsync(new OwnersView());

    }
}
