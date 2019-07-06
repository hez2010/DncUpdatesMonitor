using DncUpdatesMonitor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DncUpdatesMonitor.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ReleaseIndexInfo> releaseIndexes = new ObservableCollection<ReleaseIndexInfo>();
        public ObservableCollection<ReleaseIndexInfo> ReleaseIndexes { get => releaseIndexes; set { releaseIndexes = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReleaseIndexes))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
