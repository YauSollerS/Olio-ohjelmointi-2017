using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Labra11_DemoX3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //koska iseampi metodi-tapahtumankäs
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }

        private void IniMyStuff()
        {
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Jaws");
            muuvit.Add("Star Wars");
            muuvit.Add("Pahat pojat");
            cmbMovies.ItemsSource = muuvit;

            //haetaan SMLoog-joukkueet
            liiga = new JAMK.ICT.HockeyLeague();
           
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //määritellään Stackpaneling DataContext
            //Data1: Dataconteksini on olio
            //HockeyTeam tiimi = new JAMK.ICT.HockeyTeam("KeuPa","Keuruu");
            //spRight.DataContext = tiimi;
            //demo2: kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }
    }
}
