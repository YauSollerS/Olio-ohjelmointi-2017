﻿using System;
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

namespace Labra9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int luku;
        public MainWindow()
        {
            InitializeComponent();
            luku = 0;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtHello.Text = "Hello " + txtName.Text;
           // MessageBox.Show("Terve " + txtName.Text, "Yauheni's Messut");
            
            luku++;
            string wat = luku.ToString();
            txbCounter.Text = wat;

            //ilmoitus tilariville
            txbMessages.Text = "Painoit buttosta btnSayHello";
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            About aboutWin = new Labra9.About();
            aboutWin.ShowDialog();
        }
    }
}
