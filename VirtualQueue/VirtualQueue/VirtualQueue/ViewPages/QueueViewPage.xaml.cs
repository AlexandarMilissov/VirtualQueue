using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQL_Connection.Entities;
using System.Threading;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QueueViewPage : ContentPage
    {
        static int timeForOnePearson = 30;
        static int timeToUpdate = 1000;

        Queue queue = new Queue();
        public QueueViewPage()
        {
            InitializeComponent();
            UpdateText();
            Thread updateText = new Thread(KeepUpdatingText);
            updateText.Start();
        }

        public void UpdateText()
        { 
            queue.LocationName = "banana";
            if (queue.Users == null)
                queue.Users = new List<User>();
            queue.Users.Add(new User());
            //todo update info
            string text = $"Hello! You are looking at {queue.LocationName} queue." +
                    $" It currently has {queue.Users.Count} people in the queue." +
                    $" It will take apporximately {timeForOnePearson * queue.Users.Count} minutes";
            Device.BeginInvokeOnMainThread(() => {
                Info.Text = text;
            });
        }
        public void KeepUpdatingText()
        {
            while(true)
            {
                UpdateText();
                Thread.Sleep(timeToUpdate);
            }
        }
        private void AddToQueue(object sender, EventArgs e)
        {
            AddToQueueButton.Text = "Remove me from this queue";
            AddToQueueButton.Clicked += RemoveFromQueue;
            AddToQueueButton.Clicked -= AddToQueue;
            //todo: add this user
            UpdateText();
        }
        private void RemoveFromQueue(object sender, EventArgs e)
        {
            AddToQueueButton.Text = "Add me to this queue";
            AddToQueueButton.Clicked -= RemoveFromQueue;
            AddToQueueButton.Clicked += AddToQueue;
            //todo: add this user
                
            UpdateText();
        }
    }
}