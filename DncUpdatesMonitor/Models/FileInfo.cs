using Newtonsoft.Json;
using System.ComponentModel;

namespace DncUpdatesMonitor.Models
{
    class FileInfo : INotifyPropertyChanged
    {
        private string name;
        private string platformId;
        private string url;
        private string hash;

        [JsonProperty("name")]
        public string Name { get => name; set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name))); } }
        [JsonProperty("rid")]
        public string PlatformId { get => platformId; set { platformId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlatformId))); } }
        [JsonProperty("url")]
        public string Url { get => url; set { url = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Url))); } }
        [JsonProperty("hash")]
        public string Hash { get => hash; set { hash = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hash))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
