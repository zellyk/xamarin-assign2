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
    public partial class RegisterPage : ContentPage, INotifyPropertyChanged
    {

        public new event PropertyChangedEventHandler PropertyChanged;

        private User _user;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(User)));
            }
        }

        public RegisterPage()
        {
            _user = new User();
            InitializeComponent();
            BindingContext = this;
        }

        private async void btnRegister_ClickedAsync(object sender, EventArgs args)
        {
            //string userName = a.Text;
            //string passWord = b.Text;
            //string phone = c.Text;
            //string email = d.Text;

            (int _, string userName, string email, string passWord, string phone) = _user;

            // var user = new User { Username = userName, Password = passWord, Email = email, Phone = phone };
            if (!(string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord)))
            {
                if(!_user.IsValid(out string message))
                {
                    await DisplayAlert("Register result", message, "OK");
                }
                else
                {
                    await App.Users.Value.SaveAsync(_user);
                    //await DisplayAlert("Register result", "Success", "OK");
                    await Navigation.PopAsync();
                    //await Navigation.PushAsync(new LoginPage());
                }
            }
            else
            {
                await DisplayAlert("Register result", "Failure", "OK");
            }

        }
    }
}
