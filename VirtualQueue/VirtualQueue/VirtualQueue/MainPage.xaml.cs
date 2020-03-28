using System;
using System.ComponentModel;
using VirtualQueue.ViewPages;
using Xamarin.Forms;

namespace VirtualQueue
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
        private async void Register(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        private async void JoinQueue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JoinQueue());
        }
    }
}
