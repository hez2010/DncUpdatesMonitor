using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace DncUpdatesMonitor.Models
{
    class ComponentInfo : INotifyPropertyChanged
    {
        private string version;
        private string versionDisplay;
        private string vsVersion;
        private string vsSupport;
        private string cSharpVersion;
        private string fSharpVersion;
        private string vBharpVersion;
        private List<string> aspNetCoreModule;
        private List<FileInfo> files;

        [JsonProperty("version")]
        public string Version { get => version; set { version = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Version))); } }
        [JsonProperty("version-display")]
        public string VersionDisplay { get => versionDisplay; set { versionDisplay = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VersionDisplay))); } }
        [JsonProperty("vs-version")]
        public string VsVersion { get => vsVersion; set { vsVersion = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VsVersion))); } }
        [JsonProperty("vs-support")]
        public string VsSupport { get => vsSupport; set { vsSupport = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VsSupport))); } }
        [JsonProperty("csharp-version")]
        public string CSharpVersion { get => cSharpVersion; set { cSharpVersion = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CSharpVersion))); } }
        [JsonProperty("fsharp-version")]
        public string FSharpVersion { get => fSharpVersion; set { fSharpVersion = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FSharpVersion))); } }
        [JsonProperty("vb-version")]
        public string VBharpVersion { get => vBharpVersion; set { vBharpVersion = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VBharpVersion))); } }
        [JsonProperty("version-aspnetcoremodule")]
        public List<string> AspNetCoreModule { get => aspNetCoreModule; set { aspNetCoreModule = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AspNetCoreModule))); } }
        [JsonProperty("files")]
        public List<FileInfo> Files { get => files; set { files = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Files))); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
