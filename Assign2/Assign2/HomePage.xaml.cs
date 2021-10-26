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
    public partial class HomePage : ContentPage
    {
        public List<User> Users;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
            LoadUsers();
        }

        private async void LoadUsers()
        {
            Users = await App.Users.Value.GetAsync();
            users.ItemsSource = Users;

        }
    }
}