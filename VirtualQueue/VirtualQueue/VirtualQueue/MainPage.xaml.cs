using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public MainPage()
        {
            BindingContext = mainPageViewModel;
            InitializeComponent();
        }


        private void TextChanged(object sender, EventArgs e)
        {
            List<string> searchedItems = new List<string>();
            //todo: search database
            //based on SearchFilter.Text


            searchedItems.Add("tuk");
            mainPageViewModel.Places.Clear();
            foreach(var p in searchedItems)
            {
                mainPageViewModel.Places.Add(p);
            }
        }
        private void SearchItemTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
