using HT.ViewModels;
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
using System.Windows.Threading;

namespace HT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _clockTimer;

        public MainWindow()
        {
            InitializeComponent();

            _clockTimer = new DispatcherTimer();
            _clockTimer.Interval = new TimeSpan(1000);
            _clockTimer.Tick += _clockTimer_Tick;
            _clockTimer.Start();



        }

        private void _clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Content = DateTime.Now.ToShortTimeString();
        }

        private void btnTuotteet_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new TuotteetViewModel();
        }

        private void btnMyynti_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MyyntiViewModel();
        }

        private void btnHistoria_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new HistoriaViewModel();
        }

        private void btnToimittajat_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new TuottajatViewModel();
        }
    }
}
