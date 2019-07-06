using Newtonsoft.Json;
using System.ComponentModel;

namespace DncUpdatesMonitor.Models
{
    class CveInfo : INotifyPropertyChanged
    {
        private string cveId;
        private string cveUrl;

        [JsonProperty("cve-id")]
        public string CveId { get => cveId; set { cveId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CveId))); } }
        [JsonProperty("cve-url")]
        public string CveUrl { get => cveUrl; set { cveUrl = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CveUrl))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
