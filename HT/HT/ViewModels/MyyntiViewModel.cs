using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HT.ViewModels
{
    public class MyyntiViewModel : ObservableObject
    {
        private ObservableCollection<Tuote> _tuoteList { get; set; }
        
        public ObservableCollection<Tuote> Tuotteet { get; set; }
        
        public ObservableCollection<KoriViewModel> Kori { get; set; }
        
        public Toimitustavat SelectedToimitus { get; set; }

        
        private ICommand _lisaaKoriin { get; set; }
        private ICommand _poistaKorista { get; set; }

        
        private double _ostoHinta { get; set; }
        private double _toimitus { get; set; }
        private double _verot { get; set; }
        private double _yhteensa { get; set; }

        
       
        public double OstoHinta
        {
            get
            {
                return _ostoHinta;
            }
            set
            {
                _ostoHinta = Math.Round(value, 2);
                OnPropertyChanged("Ostohinta");
            }
        }
        public double Toimitus
        {
            get
            {
                return _toimitus;
            }
            set
            {
                _toimitus = Math.Round(value, 2);
                OnPropertyChanged("Toimitus");
            }
        }

        public double Verot
        {
            get
            {
                return _verot;
            }
            set
            {
                _verot = Math.Round(value, 2);
                OnPropertyChanged("Verot");
            }
        }
        public double Yhteensa
        {
            get
            {
                return _yhteensa;
            }
            set
            {
                _yhteensa = Math.Round(value, 2);
                OnPropertyChanged("Yhteensa");
            }
        }

        public ICommand LisaaKoriinCommand
        {
            get
            {
                return _lisaaKoriin;
            }
        }

        public ICommand PoistaKoristaCommand
        {
            get
            {
                return _poistaKorista;
            }
        }

        public MyyntiViewModel()
        {
            
            Kori = new ObservableCollection<KoriViewModel>();
            
            _tuoteList= Tallennukset.LoadTuoteList();
            
            Tuotteet = _tuoteList;
            
            _lisaaKoriin = new RelayCommand(LisaaTuoteKoriin);
            _poistaKorista = new RelayCommand(PoistaTuoteKorista);
        }

        
        public void LisaaTuoteKoriin(object tuote)
        {
            
            var uusiTuote = tuote as Tuote;
            
            var existingItem = Kori.FirstOrDefault(param => param.Tuote.Id == uusiTuote.Id);

            
            if (existingItem != null)
                existingItem.LisaaMaara(1);
            else
            {
                
                var koriEsine = new KoriViewModel(uusiTuote);
                Kori.Add(koriEsine);
            }

            
            UpdateSaldo();
        }

        
        public void PoistaTuoteKorista(object tuote)
        {
            var vanhaTuote = tuote as Tuote;
            Kori.Remove(Kori.First(i => i.Tuote == vanhaTuote));
            UpdateSaldo();
        }

        
        public List<Tuote> KoriTuotteet()
        {
            var tuotteet = new List<Tuote>();
            foreach (var item in Kori)
            {
                tuotteet.Add(item.Tuote);
            }

            return tuotteet;
        }

        
        public void LiiketoimiViimeistelty()
        {
            Kori.Clear();
        }

        public void ClearLiiketoimi()
        {
            Kori = new ObservableCollection<KoriViewModel>();
            OstoHinta = 0;
            Toimitus = 0;
            Verot = 0;
            Yhteensa = 0;
        }

    
    
        private void UpdateSaldo()
        {
            double osto = 0;
            double verot = 0;

            foreach (var item in Kori)
            {
                osto += item.Tuote.Hinta * item.Maara;
                verot += (item.Tuote.Hinta * 0.24) * item.Maara;
            }

            OstoHinta = osto;
            Verot = verot;
            Toimitus = 8;
            Yhteensa = OstoHinta + Toimitus + Verot;
        }
    }
}
