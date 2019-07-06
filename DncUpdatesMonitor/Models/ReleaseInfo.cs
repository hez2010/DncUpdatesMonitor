using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DncUpdatesMonitor.Models
{
    class ReleaseInfo : INotifyPropertyChanged
    {
        private string channelVersion;
        private string latestRelease;
        private DateTime? latestReleaseDate;
        private string latestRuntime;
        private string latestSdk;
        private string supportPhase;
        private DateTime? eolDate;
        private string lifeCyclePolicy;

        [JsonProperty("channel-version")]
        public string ChannelVersion { get => channelVersion; set { channelVersion = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChannelVersion))); } }
        [JsonProperty("latest-release")]
        public string LatestRelease { get => latestRelease; set { latestRelease = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestRelease))); } }
        [JsonProperty("latest-release-date")]
        public DateTime? LatestReleaseDate { get => latestReleaseDate; set { latestReleaseDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestReleaseDate))); } }
        [JsonProperty("latest-runtime")]
        public string LatestRuntime { get => latestRuntime; set { latestRuntime = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestRuntime))); } }
        [JsonProperty("latest-sdk")]
        public string LatestSdk { get => latestSdk; set { latestSdk = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LatestSdk))); } }
        [JsonProperty("support-phase")]
        public string SupportPhase { get => supportPhase; set { supportPhase = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SupportPhase))); } }
        [JsonProperty("eol-date")]
        public DateTime? EolDate { get => eolDate; set { eolDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EolDate))); } }
        [JsonProperty("lifecycle-policy")]
        public string LifeCyclePolicy { get => lifeCyclePolicy; set { lifeCyclePolicy = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LifeCyclePolicy))); } }
        [JsonProperty("releases")]
        public List<ReleaseDetailsInfo> ReleaseDetails { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
