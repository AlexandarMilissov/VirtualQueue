using SQL_Connection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManagerView : ContentPage
    {
        Queue queue = new Queue();
        int timeToUpdate = 1000;
        public ManageQueueveViewModel manageQueueveViewModel = new ManageQueueveViewModel();
        public ManagerView()
        {
            BindingContext = manageQueueveViewModel;
            InitializeComponent();
            Thread updateView = new Thread(KeepUpdatingView);
            updateView.Start();
        }
        
        private void RemoveUser(object sender, EventArgs e)
        {
            string mac = ((Button)sender).ClassId;
            //todo: remove user based on mac
            UpdateText();
        }
        public void UpdateText()
        {   
            //delete everything from here to the next comment
            queue.LocationName = "banana";
            if (queue.Users == null)
                queue.Users = new List<User>();
            queue.Users.Add(new User());
            //todo update queue info from database
            string text = $"Hello! Your queue has {queue.Users.Count} people in the queue.";
            Device.BeginInvokeOnMainThread(() => {
                Info.Text = text;
            });
        }
        public void UpdateList()
        {
            List<User> searchedItems = new List<User>();
            searchedItems = queue.Users;
            //todo: search database
            Device.BeginInvokeOnMainThread(() => {
                manageQueueveViewModel.Users.Clear();
                foreach (var p in searchedItems)
                {
                    manageQueueveViewModel.Users.Add(p);
                }
            });
        }
        public void KeepUpdatingView()
        {
            while (true)
            {
                UpdateText();
                UpdateList();
                Thread.Sleep(timeToUpdate);
            }
        }
    }
}