using System.Collections.ObjectModel;

namespace VirtualQueue
{
    public class MainPageViewModel
    {
        public ObservableCollection<string> Places { get; set; }
        public MainPageViewModel()
        {
            Places = new ObservableCollection<string>();
        }
    }
}