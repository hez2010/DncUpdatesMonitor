using DncUpdatesMonitor.Models;
using DncUpdatesMonitor.ViewModels;
using HeyRed.MarkdownSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DncUpdatesMonitor.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly MainPageViewModel viewModel = new MainPageViewModel();
        public MainPage()
        {
            this.InitializeComponent();

            // Setup title bar style
            Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var titleBar = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            Window.Current.SetTitleBar(MyTitleBar);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var index = await App.httpClient.GetStringAsync(App.initInfoUri);
            var json = JObject.Parse(index);
            viewModel.ReleaseIndexes.AddRange(json["releases-index"].ToObject<List<ReleaseIndexInfo>>());
            Requesting.IsActive = false;
        }

        private void NaviMenu_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItem is ReleaseIndexInfo item)
            {
                NaviContent.Navigate(typeof(ChannelVersionPage), item);
            }
        }
    }
}
