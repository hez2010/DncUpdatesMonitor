using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DncUpdatesMonitor.Models
{
    class ReleaseDetailsInfo : INotifyPropertyChanged
    {
        private DateTime? releaseDate;
        private string version;
        private bool security;
        private List<CveInfo> cveList;
        private string releaseNotes;
        private ComponentInfo runtimeInfo;
        private ComponentInfo sdkInfo;
        private ComponentInfo aspNetCoreInfo;
        private ComponentInfo symbolsInfo;

        [JsonProperty("release-date")]
        public DateTime? ReleaseDate { get => releaseDate; set { releaseDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReleaseDate))); } }
        [JsonProperty("release-version")]
        public string Version { get => version; set { version = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Version))); } }
        [JsonProperty("security")]
        public bool Security { get => security; set { security = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Security))); } }
        [JsonProperty("cve-list")]
        public List<CveInfo> CveList { get => cveList; set { cveList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CveList))); } }
        [JsonProperty("release-notes")]
        public string ReleaseNotes { get => releaseNotes; set { releaseNotes = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReleaseNotes))); } }
        [JsonProperty("runtime")]
        public ComponentInfo RuntimeInfo { get => runtimeInfo; set { runtimeInfo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RuntimeInfo))); } }
        [JsonProperty("Sdk")]
        public ComponentInfo SdkInfo { get => sdkInfo; set { sdkInfo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SdkInfo))); } }
        [JsonProperty("aspnetcore-runtime")]
        public ComponentInfo AspNetCoreInfo { get => aspNetCoreInfo; set { aspNetCoreInfo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AspNetCoreInfo))); } }
        [JsonProperty("symbols")]
        public ComponentInfo SymbolsInfo { get => symbolsInfo; set { symbolsInfo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SymbolsInfo))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
