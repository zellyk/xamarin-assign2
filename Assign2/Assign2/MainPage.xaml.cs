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

        async void VetList(System.Object sender, System.EventArgs e) => await Navigation.PushAsync(new VetList());
    }
}
