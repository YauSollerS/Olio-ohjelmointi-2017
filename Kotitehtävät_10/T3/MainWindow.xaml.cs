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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            Lotto lotto = new Lotto();
            int rows;
            if (int.TryParse(txbNumDraw.Text, out rows))
            {
                txtOutput.Text = lotto.DrawLine(cmbPelit.SelectedIndex, rows);
            }
            else
            {
                MessageBox.Show("ERROR", "Anna rivimäärä");
            }
        }
    }

    public class Lotto
    {
        private List<List<int>> rivit;
        private List<string> output;
        public Lotto()
        {
            rivit = new List<List<int>>();
            output = new List<string>();
        }
        public string DrawLine(int peli, int rows)
        {
            Random rnd = new Random();
            if (peli == 0)
            {
                // create rows
                for (int i = 0; i < rows; i++)
                {
                    rivit.Add(new List<int>());
                }
                // add numbers to rows
                foreach (List<int> item in rivit)
                {
                    for (int j = 0; j < 7;)
                    {
                        int num = rnd.Next();
                        if (!item.Contains(num))
                        {
                            item.Add(num);
                            j++;
                        }
                    }
                }
                foreach (List<int> item in rivit)
                {
                    output.Add("Rivi: ");
                    item.Sort();
                    output.Add(String.Join(", ", item));
                    output.Add("\n");
                }
                string outstring = "";
                foreach (var item in output)
                {
                    outstring = outstring + item.ToString();
                }
                return outstring;
            }
            else if (peli == 1)
            {
                return null;
            }
            else if (peli == 2)
            {

                return null;
            }
            return null;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
