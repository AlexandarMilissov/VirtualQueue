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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        private async void RegisterUser(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterUser());
        }
        private async void RegisterManager(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterManager());
        }
    }
}