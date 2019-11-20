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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rekenmachine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        string invoer = string.Empty;
        string getal1 = string.Empty;
        string getal2 = string.Empty;
        string getal3 = string.Empty;
        char operatie;
        double resultaat = 0.0;

        public void CEClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.invoer = string.Empty;
            this.getal1 = string.Empty;
            this.getal2 = string.Empty;
            this.getal3 = string.Empty;
        }

        public void CClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.invoer = string.Empty;
            this.getal1 = string.Empty;
            this.getal2 = string.Empty;
            this.getal3 = string.Empty;
        }

        public void BClick(object sender, RoutedEventArgs e)
        {
            //???
        }

        public void DelenClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            operatie = '/';
            invoer = string.Empty;
        }

        public void ZevenClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 7;
            this.Uitkomst.Text += invoer;
        }

        public void AchtClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 8;
            this.Uitkomst.Text += invoer;
        }

        public void NegenClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 9;
            this.Uitkomst.Text += invoer;
        }

        public void KeerClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            operatie = 'X';
            invoer = string.Empty;
        }

        public void VierClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 4;
            this.Uitkomst.Text += invoer;
        }

        public void VijfClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 5;
            this.Uitkomst.Text += invoer;
        }

        public void ZesClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 6;
            this.Uitkomst.Text += invoer;
        }

        public void MinClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            operatie = '-';
            invoer = string.Empty;
        }

        public void EenClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 1;
            this.Uitkomst.Text += invoer;
        }

        public void TweeClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 2;
            this.Uitkomst.Text += invoer;
        }

        public void DrieClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 3;
            this.Uitkomst.Text += invoer;
        }

        public void PlusClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            operatie = '+';
            invoer = string.Empty;
        }

        public void ModuloClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            operatie = '%';
            invoer = string.Empty;
        }

        public void NulClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += 0;
            this.Uitkomst.Text += invoer;
        }

        public void KommaClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            invoer += ',';
            this.Uitkomst.Text += invoer;
        }

        public void IsClick(object sender, RoutedEventArgs e)
        {
            getal2 = invoer;
            double nummer1, nummer2, nummer3;
            double.TryParse(getal1, out nummer1);
            double.TryParse(getal2, out nummer2);
            double.TryParse(getal3, out nummer3);

            if (operatie == '+')
            {
                resultaat = nummer1 + nummer2 + nummer3;
                Uitkomst.Text = resultaat.ToString();
            }
            else if (operatie == '-')
            {
                resultaat = nummer1 - nummer2;
                Uitkomst.Text = resultaat.ToString();
            }
            else if (operatie == 'X')
            {
                resultaat = nummer1 * nummer2;
                Uitkomst.Text = resultaat.ToString();
            }
            else if (operatie == '/')
            {
                if (nummer2 != 0)
                {
                    resultaat = nummer1 / nummer2;
                    Uitkomst.Text = resultaat.ToString();
                }
                else
                {
                    Uitkomst.Text = "Je kunt niet delen door 0!";
                }
<<<<<<< HEAD


=======
            }
            else if (operatie == '%')
            {
                resultaat = nummer1 % nummer2;
                Uitkomst.Text = resultaat.ToString();
>>>>>>> 37ca6b5b74aa0da6cd54ccfd69ce7653f1c88bf9
            }
        }
    }
}
