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
            string phone = c.Text;
            string email = d.Text;

            var user = new User { Username = userName, Password = passWord, Email = email, Phone = phone };
            if (!(string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord)))
            {
                if(!user.IsValid(out var message))
                {
                    await DisplayAlert("Register result", message, "OK");
                }
                else
                {
                    await App.Users.Value.SaveAsync(user);
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
