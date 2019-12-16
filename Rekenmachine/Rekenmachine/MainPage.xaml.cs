using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Media.Capture;
using Windows.Media.Core;
using Windows.UI.Core;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;

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


        // Replace <Subscription Key> with your valid subscription key.
        const string subscriptionKey = "230b4a3b313e43b9aab10e464672a601";

        // replace <myresourcename> with the string found in your endpoint URL
        const string uriBase =
            "https://facedetectionscrum.cognitiveservices.azure.com/face/v1.0/detect?";

        async void Main()
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".png");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                this.path.Text = file.Name;
            }
            else
            {
                this.path.Text = "Er is een fout opgetreden";
            }

            // Get the path and filename to process from the user.
            string imageFilePath = file.Name;

            MakeAnalysisRequest(imageFilePath);
        }

        // Gets the analysis of the specified image by using the Face REST API.
        async void MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", subscriptionKey);

            // Request parameters. A third optional parameter is "details".
            string requestParameters = "&returnFaceAttributes=age";
            // Assemble the URI for the REST API Call.
            string uri = uriBase + "?" + requestParameters;

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json"
                // and "multipart/form-data".
                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = await client.PostAsync(uri, content);

                // Get the JSON response.
                string contentString = await response.Content.ReadAsStringAsync();

                dynamic faceobj = JsonConvert.DeserializeObject(contentString);


                // Display the JSON response.
                path.Text = "Leeftijd = " + faceobj[0]["faceAttributes"]["age"];
                if (faceobj[0]["faceAttributes"]["age"] >= 15)
                {
                    verder.IsEnabled = true;
                    verder.Opacity = 1;
                }
                else
                {
                    path.Text = "Je bent niet oud genoeg";
                }

            }
        }

        // Returns the contents of the specified file as a byte array.
        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }

        public void Klik(object sender, RoutedEventArgs e)
        {
            Main();
        }
    }
}