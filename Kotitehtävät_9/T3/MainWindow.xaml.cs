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

namespace T3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double leveys;
        private double korkeus;
        private double karmi;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                leveys = Convert.ToDouble(textBox1.Text);
                korkeus = Convert.ToDouble(textBox2.Text);
                karmi = Convert.ToDouble(textBox3.Text);

                double ikkpinta = leveys * korkeus;
                double laspinta = ikkpinta - (karmi * korkeus * 2 + 45 * (leveys - 2 * karmi) * 2);

                string value1 = ikkpinta.ToString();
                string value2 = laspinta.ToString();
                textBox4.Text = value1 + " cm^2";
                textBox5.Text = value2 + " cm^2";
            }
            catch (FormatException)
            {
                textBox4.Text = " ERROR!";
                textBox5.Text = " ERROR!";
                textBox6.Text = " ERROR!";
            }
        }
    }
}
