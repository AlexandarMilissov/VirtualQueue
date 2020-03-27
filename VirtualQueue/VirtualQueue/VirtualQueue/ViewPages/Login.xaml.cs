using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void LoginUser(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginUser());
        }
        private async void LoginManager(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginManager());
        }
    }
}