using DncUpdatesMonitor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DncUpdatesMonitor.ViewModels
{
    class ChannelVersionPageViewModel : INotifyPropertyChanged
    {
        private ReleaseIndexInfo releaseIndex = new ReleaseIndexInfo();
        public ReleaseIndexInfo ReleaseIndex { get => releaseIndex; set { releaseIndex = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReleaseIndex))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
