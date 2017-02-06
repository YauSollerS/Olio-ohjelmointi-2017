using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace T1
{
    /// <summary>
    /// Tehtävä 1 - Autolaskuri
    /// Opiskelija on saanut itselleen unelma kesätyön vilkasliikenteisen kadun varrelta.Hänen tulee laskea ohi menevät
    /// henkilö- ja kuorma-autot.Laadi opiskelijalle sovellus, jolla hän voi laskea helposti ohi menneet autot.Painikkeita 
    /// painettaessa ko. kulkuneuvon osoittama lukumäärä kasvaa yhdellä.
    /// </summary>
    public partial class MainWindow : Window
    {
        private int trucks;
        private int cars;
        public MainWindow()
        {
            InitializeComponent();
            trucks = 0;
            cars = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            string trakki = trucks.ToString();
            textBlock.Text = trakki;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            string autot = cars.ToString();
            textBlock_Copy.Text = autot;
        }
    }
}
