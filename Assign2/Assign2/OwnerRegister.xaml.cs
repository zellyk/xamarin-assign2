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
    public partial class OwnerRegister : ContentPage, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private Owner _owner;

        public Owner Owner
        {
            get => _owner;
            set
            {
                _owner = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Owner)));
            }
        }

        public OwnerRegister()
        {
            _owner = new Owner();
            InitializeComponent();
            BindingContext = this;
        }

        public async void Register(object sender, EventArgs args)
        {

            await App.Owners.Value.SaveAsync(_owner);
            await Navigation.PopAsync();
        }
    }
}

