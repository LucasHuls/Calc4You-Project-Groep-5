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
            this.Uitkomst.Text = "";
            this.invoer = string.Empty;
            this.getal1 = string.Empty;
            this.getal2 = string.Empty;
            this.Som.Text = "";
        }

        public void DelenClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            this.Som.Text += "/";
            operatie = '/';
            invoer = string.Empty;
        }

        public void ZevenClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "7";
            invoer += 7;
            this.Uitkomst.Text += invoer;
        }

        public void AchtClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "8";
            invoer += 8;
            this.Uitkomst.Text += invoer;
        }

        public void NegenClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "9";
            invoer += 9;
            this.Uitkomst.Text += invoer;
        }

        public void KeerClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            this.Som.Text += "X";
            operatie = 'X';
            invoer = string.Empty;
        }

        public void VierClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "4";
            invoer += 4;
            this.Uitkomst.Text += invoer;
        }

        public void VijfClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "5";
            invoer += 5;
            this.Uitkomst.Text += invoer;
        }

        public void ZesClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "6";
            invoer += 6;
            this.Uitkomst.Text += invoer;
        }

        public void MinClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            this.Som.Text += "-";
            operatie = '-';
            invoer = string.Empty;
        }

        public void EenClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "1";
            invoer += 1;
            this.Uitkomst.Text += invoer;
        }

        public void TweeClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "2";
            invoer += 2;
            this.Uitkomst.Text += invoer;
        }

        public void DrieClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "3";
            invoer += 3;
            this.Uitkomst.Text += invoer;
        }

        public void PlusClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            this.Som.Text += "+";
            operatie = '+';
            invoer = string.Empty;
        }

        public void ModuloClick(object sender, RoutedEventArgs e)
        {
            getal1 = invoer;
            this.Som.Text += "%";
            operatie = '%';
            invoer = string.Empty;
        }

        public void NulClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += "0";
            invoer += 0;
            this.Uitkomst.Text += invoer;
        }

        public void KommaClick(object sender, RoutedEventArgs e)
        {
            this.Uitkomst.Text = "";
            this.Som.Text += ",";
            invoer += ',';
            this.Uitkomst.Text += invoer;
        }

        public void IsClick(object sender, RoutedEventArgs e)
        {
            getal2 = invoer;
            double nummer1, nummer2;
            double.TryParse(getal1, out nummer1);
            double.TryParse(getal2, out nummer2);
            this.Som.Text = "";

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
            double euro = Convert.ToInt32(invoer);
            euro *= 1.1083;
            Uitkomst.Text = euro.ToString(); 

        }

        private void BinearClick(object sender, RoutedEventArgs e)
        {
            var binair = Convert.ToString(Convert.ToInt32(invoer), 2);
            Uitkomst.Text = Convert.ToString(binair);
        }

        private void PlusMinClick(object sender, RoutedEventArgs e)
        {
            double plusMin = Convert.ToDouble(invoer);
            plusMin -= plusMin * 2;
            invoer = Convert.ToString(plusMin);
            Uitkomst.Text = invoer;
        }
    }
}