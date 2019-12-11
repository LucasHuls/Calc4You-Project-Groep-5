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
<<<<<<< HEAD
            Uitkomst.FontSize = 64; //Lettergroote van de Font
            Uitkomst.Text = ""; //Hier komt de lege tekst te staan
            invoer = string.Empty; //Variabel invoer
            getal1 = string.Empty; //getal 1 invoer
            getal2 = string.Empty; //getal 2 invoer
            Som.Text = ""; //Uitkomst invoer
        }

        public void DelenClick(object sender, RoutedEventArgs e) //Delen Knop
        {
            getal1 = invoer; //Variabele getal 1
            Som.Text += "/"; //Lege invoer
            operatie = '/'; //Variabele
            invoer = string.Empty; //Maakt de string leeg   
        }

        public void ZevenClick(object sender, RoutedEventArgs e) //Zeven Knop
        {
            Uitkomst.Text = ""; //Lege uitkomst
            Som.Text += "7"; //Invoer zeven
            invoer += 7; //Invoer variabele
            Uitkomst.Text += invoer; //Uitkomst van veriabele invoer
        }

        public void AchtClick(object sender, RoutedEventArgs e) //Acht Knop
        {
            Uitkomst.Text = ""; 
            Som.Text += "8"; 
            invoer += 8; 
            Uitkomst.Text += invoer; 
        }

        public void NegenClick(object sender, RoutedEventArgs e) //Negen Knop
        {
            Uitkomst.Text = ""; 
            Som.Text += "9"; 
            invoer += 9; 
            Uitkomst.Text += invoer; 
        }
=======
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
>>>>>>> fa72edb42a2fa524f029f488ba9aa9938d4a8fd3

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

<<<<<<< HEAD
        public void PlusClick(object sender, RoutedEventArgs e) //+, Plus Knop
        {
            getal1 = invoer; //String invoer
            Som.Text += "+"; //Som neemt toe
            operatie = '+'; //Uitvoering
            invoer = string.Empty; //Lege string
        }

        public void ModuloClick(object sender, RoutedEventArgs e) //%, Modulo Knop
        {
            getal1 = invoer; //Variable invoer
            Som.Text += "%"; //Som procent
            operatie = '%'; //Procent uitvoer
            invoer = string.Empty; //Lege invoer
        }
=======
            static byte[] GetImageAsByteArray(string imageFilePath)
            {
                FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }

            static async void MakeAnalysisRequest(string imageFilePath)
            {
                var client = new HttpClient();
>>>>>>> fa72edb42a2fa524f029f488ba9aa9938d4a8fd3

                // Request headers - replace this example key with your valid key.
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "230b4a3b313e43b9aab10e464672a601");

                // Request parameters and URI string.
                string queryString = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender";
                string uri = "https://facedetectionscrum.cognitiveservices.azure.com/face/v1.0/detect?" + queryString;

                HttpResponseMessage response;
                string responseContent;

<<<<<<< HEAD
        public void IsClick(object sender, RoutedEventArgs e) //=, is knop
        {
            getal2 = invoer; //Variable
            double nummer1, nummer2;
            double.TryParse(getal1, out nummer1);
            double.TryParse(getal2, out nummer2);
            Som.Text = "";
=======
                // Request body. Try this sample with a locally stored JPEG image.
                byte[] byteData = GetImageAsByteArray(imageFilePath);
>>>>>>> fa72edb42a2fa524f029f488ba9aa9938d4a8fd3

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