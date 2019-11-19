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

        private void CEClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
        }

        private void CClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text = "";
        }

        private void BClick(object sender, RoutedEventArgs e)
        {
            //???
        }

        private void DelenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "/";
        }

        private void ZevenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "7";
        }

        private void AchtClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "8";
        }

        private void NegenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "9";
        }

        private void KeerClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "X";
        }

        private void VierClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "4";
        }

        public void VijfClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "5";
        }

        public void ZesClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "6";
        }

        private void MinClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "-";
        }

        private void EenClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "1";
        }

        private void TweeClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "2";
        }

        private void DrieClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "3";
        }

        private void PlusClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "+";
        }

        private void ModuloClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "%";
        }

        private void NulClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += "0";
        }

        private void KommaClick(object sender, RoutedEventArgs e)
        {
            Uitkomst.Text += ",";
        }

        public void IsClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
