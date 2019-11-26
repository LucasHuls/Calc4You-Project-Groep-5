using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

        private string invoer = string.Empty; //Gebruikers invoer
        private string getal1 = string.Empty; //Variabel opslag eerste invoer
        private string getal2 = string.Empty; //Variabel opslag tweede invoer
        private char operatie; //Operatie (X, /, %, -, + ETC...)
        private double resultaat = 0.0; //Variabel eindresultaat

        public void CEClick(object sender, RoutedEventArgs e) //CE Knop, reset alle variabelen
        {
            Uitkomst.FontSize = 64;
            Uitkomst.Text = "";
            invoer = string.Empty;
            getal1 = string.Empty;
            getal2 = string.Empty;
            Som.Text = "";
        }

        public void DelenClick(object sender, RoutedEventArgs e) //Delen Knop
        {
            getal1 = invoer;
            Som.Text += "/";
            operatie = '/';
            invoer = string.Empty;
        }

        public void ZevenClick(object sender, RoutedEventArgs e) //Zeven Knop
        {
            Uitkomst.Text = "";
            Som.Text += "7";
            invoer += 7;
            Uitkomst.Text += invoer;
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

        public void KeerClick(object sender, RoutedEventArgs e) //X, Keer Knop
        {
            getal1 = invoer;
            Som.Text += "X";
            operatie = 'X';
            invoer = string.Empty;
        }

        public void VierClick(object sender, RoutedEventArgs e) //Vier Knop
        {
            Uitkomst.Text = "";
            Som.Text += "4";
            invoer += 4;
            Uitkomst.Text += invoer;
        }

        public void VijfClick(object sender, RoutedEventArgs e) //Vijf Knop
        {
            Uitkomst.Text = "";
            Som.Text += "5";
            invoer += 5;
            Uitkomst.Text += invoer;
        }

        public void ZesClick(object sender, RoutedEventArgs e) //Zes Knop
        {
            Uitkomst.Text = "";
            Som.Text += "6";
            invoer += 6;
            Uitkomst.Text += invoer;
        }

        public void MinClick(object sender, RoutedEventArgs e) //-, min knop
        {
            getal1 = invoer;
            Som.Text += "-";
            operatie = '-';
            invoer = string.Empty;
        }

        public void EenClick(object sender, RoutedEventArgs e) //Één Knop
        {
            Uitkomst.Text = "";
            Som.Text += "1";
            invoer += 1;
            Uitkomst.Text += invoer;
        }

        public void TweeClick(object sender, RoutedEventArgs e) //Twee Knop
        {
            Uitkomst.Text = "";
            Som.Text += "2";
            invoer += 2;
            Uitkomst.Text += invoer;
        }

        public void DrieClick(object sender, RoutedEventArgs e) //Drie Knop
        {
            Uitkomst.Text = "";
            Som.Text += "3";
            invoer += 3;
            Uitkomst.Text += invoer;
        }

        public void PlusClick(object sender, RoutedEventArgs e) //+, Plus Knop
        {
            getal1 = invoer;
            Som.Text += "+";
            operatie = '+';
            invoer = string.Empty;
        }

        public void ModuloClick(object sender, RoutedEventArgs e) //%, Modulo Knop
        {
            getal1 = invoer;
            Som.Text += "%";
            operatie = '%';
            invoer = string.Empty;
        }

        public void NulClick(object sender, RoutedEventArgs e) //Nul Knop
        {
            Uitkomst.Text = "";
            Som.Text += "0";
            invoer += 0;
            Uitkomst.Text += invoer;
        }

        public void KommaClick(object sender, RoutedEventArgs e) //Komma Knop
        {
            Som.Text += ",";
            invoer += '.';
            Uitkomst.Text += ",";
            Convert.ToDouble(invoer);
        }

        public void IsClick(object sender, RoutedEventArgs e) //=, is knop
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

        private void EurDollarClick(object sender, RoutedEventArgs e) //Euro/Dollar Knop
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

        private void BinearClick(object sender, RoutedEventArgs e) //Binaire Knop
        {
            if (invoer != string.Empty)
            {
                int invoerBinair = Convert.ToInt32(invoer); //Gebruikers input naar binairvariabel
                string binair1 = Convert.ToString(invoerBinair, 2); //base2 voor binaire encoding (radix)
                Uitkomst.Text = binair1;
            }
            else
            {
                Uitkomst.Text = "Voer iets in"; //Je kan geen 0 intypen.
            }
        }

        private void PlusMinClick(object sender, RoutedEventArgs e) //Negatief/Positief Knop
        {
            double plusMin = Convert.ToDouble(invoer);
            plusMin -= plusMin * 2;
            invoer = Convert.ToString(plusMin);
            Uitkomst.Text = invoer;
        }

        private void HexaDecimaalClick(object sender, RoutedEventArgs e) //Hexadecimaal Knop
        {
            if (invoer != string.Empty)
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