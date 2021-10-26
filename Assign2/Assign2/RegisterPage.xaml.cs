using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assign2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void btnRegister_ClickedAsync(object sender, EventArgs args)
        {
            string userName = a.Text;
            string passWord = b.Text;
            if (!(string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord)))
            {
                await App.Users.Value.SaveAsync(new User { Username = userName, Password = passWord });
                await DisplayAlert("Register result", "Success", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Register result", "Failure", "OK");
            }

        }
    }
}
