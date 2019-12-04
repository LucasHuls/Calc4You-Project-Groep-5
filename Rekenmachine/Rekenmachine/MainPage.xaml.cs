using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rekenmachine
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public async void NewScreen(object sender, RoutedEventArgs e)
        {
            var MyView = CoreApplication.CreateNewView();

            int newViewId = 0;

            await MyView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame newFrame = new Frame();
                newFrame.Navigate(typeof(Rekenmachine), null);

                Window.Current.Content = newFrame;
                Window.Current.Activate();

                newViewId = ApplicationView.GetForCurrentView().Id;
            });

            await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId, ViewSizePreference.UseMinimum);
        }

        private void Scannen_Click(object sender, RoutedEventArgs e)
        {
            if (pathText.Text == "Joejoe")
            {
                verder.IsEnabled = true;
                verder.Opacity = 1;
            }
            else
            {
                pathText.Text = "Dacht het niet he";
            }
            
        }
    }
}