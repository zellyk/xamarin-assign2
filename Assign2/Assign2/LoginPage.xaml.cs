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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_ClickedAsync(object sender, EventArgs args)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            var userAsync = await App.Users.Value.GetAsync();
            var user = userAsync.Where(n => n.Username == userName).FirstOrDefault();

            if (user != null && user.Password.Equals(passWord))
            {
                await DisplayAlert("Login result", "Success", "OK");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Login result", "Failure", "OK");
            }

        }
    }
}