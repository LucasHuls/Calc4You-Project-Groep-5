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
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

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
        }
        public class Program
        {
            /*static void Main()
            {
                Console.Write("pad van plaatje:");
                string imageFilePath = Console.ReadLine();

                MakeAnalysisRequest(imageFilePath);

                Console.WriteLine("\n\n\nResultaten...\n\n\n");
                Console.ReadLine();
            }*/

            static byte[] GetImageAsByteArray(string imageFilePath)
            {
                FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }

            static async void MakeAnalysisRequest(string imageFilePath)
            {
                var client = new HttpClient();

                // Request headers - replace this example key with your valid key.
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "230b4a3b313e43b9aab10e464672a601");

                // Request parameters and URI string.
                string queryString = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender";
                string uri = "https://facedetectionscrum.cognitiveservices.azure.com/face/v1.0/detect?" + queryString;

                HttpResponseMessage response;
                string responseContent;

                // Request body. Try this sample with a locally stored JPEG image.
                byte[] byteData = GetImageAsByteArray(imageFilePath);

                using (var content = new ByteArrayContent(byteData))
                {
                    // This example uses content type "application/octet-stream".
                    // The other content types you can use are "application/json" and "multipart/form-data".
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    response = await client.PostAsync(uri, content);
                    responseContent = response.Content.ReadAsStringAsync().Result;
                }

                //A peak at the JSON response.
                Console.WriteLine(responseContent);
            }
        }
    }
}