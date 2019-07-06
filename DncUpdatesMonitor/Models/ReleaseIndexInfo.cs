using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace DncUpdatesMonitor.Models
{
    class ReleaseIndexInfo : INotifyPropertyChanged
    {
        private string channelVersion;
        private string latestRelease;
        private DateTime? latestReleaseDate;
        private bool security;
        private string latestRuntime;
        private string latestSdk;
        private string product;
        private string supportPhase;
        private DateTime? eolDate;
        private string lifeCyclePolicy;
        private string releaseInfoUrl;

        [JsonProperty("channel-version")]
        public string ChannelVersion { get => channelVersion; set { channelVersion = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChannelVersion))); } }
        [JsonProperty("latest-release")]
        public string LatestRelease { get => latestRelease; set { latestRelease = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestRelease))); } }
        [JsonProperty("latest-release-date")]
        public DateTime? LatestReleaseDate { get => latestReleaseDate; set { latestReleaseDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestReleaseDate))); } }
        [JsonProperty("security")]
        public bool Security { get => security; set { security = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Security))); } }
        [JsonProperty("latest-runtime")]
        public string LatestRuntime { get => latestRuntime; set { latestRuntime = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestRuntime))); } }
        [JsonProperty("latest-sdk")]
        public string LatestSdk { get => latestSdk; set { latestSdk = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestSdk))); } }
        [JsonProperty("product")]
        public string Product { get => product; set { product = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Product))); } }
        [JsonProperty("support-phase")]
        public string SupportPhase { get => supportPhase; set { supportPhase = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SupportPhase))); } }
        [JsonProperty("eol-date")]
        public DateTime? EolDate { get => eolDate; set { eolDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EolDate))); } }
        [JsonProperty("lifecycle-policy")]
        public string LifeCyclePolicy { get => lifeCyclePolicy; set { lifeCyclePolicy = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LifeCyclePolicy))); } }
        [JsonProperty("releases.json")]
        public string ReleaseInfoUrl { get => releaseInfoUrl; set { releaseInfoUrl = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReleaseInfoUrl))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
