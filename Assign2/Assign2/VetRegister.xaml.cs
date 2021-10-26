using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assign2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VetRegister : ContentPage, INotifyPropertyChanged
    {

        public new event PropertyChangedEventHandler PropertyChanged;

        private Vet _vet;

        public Vet Vet
        {
            get => _vet;
            set
            {
                _vet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Vet)));
            }
        }

        public VetRegister()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public async void Register(object sender, EventArgs args)
        {
            await App.Vets.Value.SaveAsync(_vet);
            await Navigation.PopAsync();
        }
    }
}