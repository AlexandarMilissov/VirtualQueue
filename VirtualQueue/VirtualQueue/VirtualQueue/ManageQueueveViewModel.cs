using SQL_Connection.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VirtualQueue
{
    public class ManageQueueveViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ManageQueueveViewModel()
        {
            Users = new ObservableCollection<User>();
        }
    }
}
