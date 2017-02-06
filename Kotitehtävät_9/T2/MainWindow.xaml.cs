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

namespace T2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double euro;
        private double dollar;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                euro = Convert.ToDouble(textBox.Text);

                dollar = euro * 1.07126;
                string value = dollar.ToString("0.00");
                textBox_Copy.Text = value;
            }
            catch (FormatException)
            {
                textBox.Text = "ENTER A NUMBER";
                
            }

        }


        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                dollar = Convert.ToDouble(textBox_Copy.Text);
                euro = dollar * 0.933480201;
                string value = euro.ToString("0.00");
                textBox.Text = value;
            }
            catch (FormatException)
            {
                textBox_Copy.Text = "ENTER A NUMBER";

            }
        }
    }
}
