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

using Windows.Media.Capture;
using Windows.Media.Core;
using Windows.Media.FaceAnalysis;
using Windows.Media.MediaProperties;
using Windows.UI.Core;
using Windows.UI.Xaml.Shapes;
using Windows.UI;
using Windows.Graphics.Imaging;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rekenmachine
{
    public sealed partial class MainPage : Page
    {
        private FaceDetectionEffect _faceDetectionEffect;
        private MediaCapture _mediaCapture;

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

            //Ervoor zorgen dat je niet maar 1 keer hoeft te scannen maar elke keer
            verder.IsEnabled = false;
            verder.Opacity = 0.5;
        }

        private async void btnCamera_Click(object sender, RoutedEventArgs e)
        {
            _mediaCapture = new MediaCapture();
            await _mediaCapture.InitializeAsync();
            cePreview.Source = _mediaCapture;
            await _mediaCapture.StartPreviewAsync();
        }

        private async void btnDetectFaces_Click(object sender, RoutedEventArgs e)
        {
            var faceDetectionDefinition = new FaceDetectionEffectDefinition();
            faceDetectionDefinition.DetectionMode = FaceDetectionMode.HighPerformance;
            faceDetectionDefinition.SynchronousDetectionEnabled = false;
            _faceDetectionEffect = (FaceDetectionEffect)await
            _mediaCapture.AddVideoEffectAsync(faceDetectionDefinition,
            MediaStreamType.VideoPreview);
            _faceDetectionEffect.FaceDetected += FaceDetectionEffect_FaceDetected;
            _faceDetectionEffect.DesiredDetectionInterval = TimeSpan.FromMilliseconds(33);
            _faceDetectionEffect.Enabled = true;
        }

        public async void FaceDetectionEffect_FaceDetected(
        FaceDetectionEffect sender, FaceDetectedEventArgs args)
        {
            var detectedFaces = args.ResultFrame.DetectedFaces;            

            verder.IsEnabled = true;
            verder.Opacity = 1;

            if (verder.IsEnabled == true)
            {
                _faceDetectionEffect.Enabled = false;
                _faceDetectionEffect.FaceDetected -= FaceDetectionEffect_FaceDetected;
                await _mediaCapture.ClearEffectsAsync(MediaStreamType.VideoPreview);
                _faceDetectionEffect = null;
                this.cvsFaceOverlay.Children.Clear();
            }

        }
    }
}