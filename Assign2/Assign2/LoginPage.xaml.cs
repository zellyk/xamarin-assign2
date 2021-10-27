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
    public partial class LoginPage : ContentPage, INotifyPropertyChanged
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
        public LoginPage()
        {
            _user = new User();
            InitializeComponent();
            BindingContext = this;
        }

        private async void btnRegister_ClickedAsync(object sender, EventArgs args) => await Navigation.PushAsync(new RegisterPage());

        private async void btnLogin_ClickedAsync(object sender, EventArgs args)
        {
            string userName = _user.Username;
            string passWord = _user.Password;

            var userAsync = await App.Users.Value.GetAsync();
            var user = userAsync.Where(n => n.Username == userName).FirstOrDefault();

            if (user != null && user.Password.Equals(passWord))
            {
                await DisplayAlert("Login result", "Success", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Login result", "Failure", "OK");
            }

        }
    }
}