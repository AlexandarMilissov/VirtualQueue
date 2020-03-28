using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQL_Connection.Entities;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QueueViewPage : ContentPage
    {
        Queue queue;
        public QueueViewPage(Queue q)
        {
            queue = q;
            InitializeComponent();
        }
    }
}