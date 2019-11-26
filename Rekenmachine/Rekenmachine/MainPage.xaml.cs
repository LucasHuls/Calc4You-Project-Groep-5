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
        char operatie;
        double resultaat = 0.0;

        public void CEClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.FontSize = 64;
            Uitkomst.Text = "";
            invoer = string.Empty;
            getal1 = string.Empty;
            getal2 = string.Empty;
            Som.Text = "";
        }

        public void DelenClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            Som.Text += "/";
            operatie = '/';
            invoer = string.Empty;
        }

        public void ZevenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "7";
            invoer += 7;
            Uitkomst.Text += invoer;
        }

        public void AchtClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "8";
            invoer += 8;
            Uitkomst.Text += invoer;
        }

        public void NegenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "9";
            invoer += 9;
            Uitkomst.Text += invoer;
        }

        public void KeerClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            Som.Text += "X";
            operatie = 'X';
            invoer = string.Empty;
        }

        public void VierClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "4";
            invoer += 4;
            Uitkomst.Text += invoer;
        }

        public void VijfClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "5";
            invoer += 5;
            Uitkomst.Text += invoer;
        }

        public void ZesClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "6";
            invoer += 6;
            Uitkomst.Text += invoer;
        }

        public void MinClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            Som.Text += "-";
            operatie = '-';
            invoer = string.Empty;
        }

        public void EenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "1";
            invoer += 1;
            Uitkomst.Text += invoer;
        }

        public void TweeClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "2";
            invoer += 2;
            Uitkomst.Text += invoer;
        }

        public void DrieClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "3";
            invoer += 3;
            Uitkomst.Text += invoer;
        }

        public void PlusClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            Som.Text += "+";
            operatie = '+';
            invoer = string.Empty;
        }

        public void ModuloClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            Som.Text += "%";
            operatie = '%';
            invoer = string.Empty;
        }

        public void NulClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
            Som.Text += "0";
            invoer += 0;
            Uitkomst.Text += invoer;
        }

        public void KommaClick(object sender, RoutedEventArgs e)
        {
            Som.Text += ",";
            invoer += '.';
            Uitkomst.Text += ",";
            Convert.ToDouble(invoer);
        }

        public void IsClick(object sender, RoutedEventArgs e)
        {
            getal2 = invoer;
            double nummer1, nummer2;
            double.TryParse(getal1, out nummer1);
            double.TryParse(getal2, out nummer2);
            Som.Text = "";

            if (operatie == '+')
            {
                resultaat = nummer1 + nummer2;
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
            }
            else if (operatie == '%')
            {
                resultaat = nummer1 % nummer2;
                Uitkomst.Text = resultaat.ToString();
            }
        }
        
        private void EurDollarClick(object sender, RoutedEventArgs e)
        {
            if (invoer != "")
            {
                double euro = Convert.ToDouble(invoer);
                euro *= 1.1083;
                Uitkomst.Text = euro.ToString(); 
            }
            else
            {
                Uitkomst.Text = "Voer iets in";
            }
        }

        private void BinearClick(object sender, RoutedEventArgs e)
        {
            if (invoer != "")
            {
                double invoerBinair = Convert.ToDouble(invoer);
                long binair = BitConverter.DoubleToInt64Bits(invoerBinair);
                string str = Convert.ToString(binair, 2);
                Uitkomst.Text = str;
                Uitkomst.FontSize = 24;
            }
            else
            {
                Uitkomst.Text = "Voer iets in";
            }
        }

        private void PlusMinClick(object sender, RoutedEventArgs e)
        {
            double plusMin = Convert.ToDouble(invoer);
            plusMin -= plusMin * 2;
            invoer = Convert.ToString(plusMin);
            Uitkomst.Text = invoer;
        }

        private void HexaDecimaalClick(object sender, RoutedEventArgs e)
        {
            if (invoer != "")
            {
                var hexa = Convert.ToString(Convert.ToInt32(invoer), 16);
                Uitkomst.Text = Convert.ToString(hexa);
            }
            else
            {
                Uitkomst.Text = "Voer iets in";
            }
        }
    }
}