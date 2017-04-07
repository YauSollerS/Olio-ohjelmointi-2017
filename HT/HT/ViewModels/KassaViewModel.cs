using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Models;
using System.Windows.Input;

namespace HT.ViewModels
{
    public class KassaViewModel : ObservableObject
    {
       
        public MyyntiViewModel Myynti { get; private set; }
        
        public Liiketoimi Liiketoimi { get; private set; }

        
        private ICommand _hyvaksyCommand { get; set; }
        public ICommand HyvaksyCommand
        {
            get
            {
                return _hyvaksyCommand;
            }
        }

        public KassaViewModel(MyyntiViewModel myynti)
        {
            
            Myynti = myynti;
            
            Liiketoimi = new Liiketoimi();
            
            _hyvaksyCommand = new RelayCommand(HyvaksyLiiketoimi);
        }

        public void HyvaksyLiiketoimi()
        {
            
            AntaaId(Liiketoimi);


            Liiketoimi.AsiakasNimi = Liiketoimi.AsiakasEnimi + " " + Liiketoimi.AsiakasSnimi;
            Liiketoimi.Aika = DateTime.Now;
            Liiketoimi.ShortDate = DateTime.Now.ToShortDateString();
            Liiketoimi.OstoHinta = Myynti.OstoHinta;
            Liiketoimi.Toimitusmaksu = Myynti.Toimitus;
            Liiketoimi.Verot = Myynti.Verot;
            Liiketoimi.Yhteensa = Myynti.Yhteensa;
            Liiketoimi.Toimitus = Myynti.SelectedToimitus;

            
            Tallennukset.SaveUusiLiiketoimi(Liiketoimi);
            Myynti.ClearLiiketoimi();
        }

        private void AntaaId(Liiketoimi liiketoimi)
        {
            
            var histori = Tallennukset.LoadLiiketoimi();

            
            liiketoimi.Id = 100;

            
            if (histori.Count > 0)
            {
                
                liiketoimi.Id = histori.Max(i => i.Id);
                liiketoimi.Id++;
            }
        }
    }
}
