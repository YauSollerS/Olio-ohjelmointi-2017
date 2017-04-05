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
    public class TuottajatViewModel : ObservableObject
    {
        public ObservableCollection<Tuottaja> Tuottajat { get; set; }

        private Tuottaja _viewedTuottaja { get; set; }

        private Tuottaja _tuottajaModel { get; set; }

        public Tuottaja ViewedTuottaja
        {
            get
            {
                return _viewedTuottaja;
            }
            set
            {
                _viewedTuottaja = value;
                OnPropertyChanged("ViewedTuottaja");
            }
        }

        public Tuottaja TuottajaModel
        {
            get
            {
                return _tuottajaModel;
            }
            set
            {
                _tuottajaModel = value;
                OnPropertyChanged("ContactModel");
            }
        }



        private ICommand _viewTuottaja { get; set; }

        public ICommand ViewTuottajaCommand
        {
            get
            {
                return _viewTuottaja;
            }
        }

        private ICommand _selectTuottaja { get; set; }

        public ICommand SelectTuottajaCommand
        {
            get
            {
                return _selectTuottaja;
            }
        }


        private ICommand _updateTuottaja { get; set; }

        public ICommand UpdateTuottajaCommand
        {
            get
            {
                return _updateTuottaja;
            }
        }


        private ICommand _clearTuottaja { get; set; }

        public ICommand ClearTuottajaCommand
        {
            get
            {
                return _clearTuottaja;
            }
        }


        private ICommand _addTuottaja { get; set; }

        public ICommand AddTuottajaCommand
        {
            get
            {
                return _addTuottaja;
            }
        }


        private ICommand _removeTuottaja { get; set; }

        public ICommand RemoveTuottajaCommand
        {
            get
            {
                return _removeTuottaja;
            }
        }

        public TuottajatViewModel()
        {
            
            Tuottajat = Tallennukset.LoadTuottajat();
            
            TuottajaModel = new Tuottaja();

            
            _viewTuottaja = new RelayCommand(ViewTuottaja);
            _selectTuottaja = new RelayCommand(SelectTuottaja);
            _updateTuottaja = new RelayCommand(UpdateTuottaja);
            _clearTuottaja = new RelayCommand(ClearTuottaja);
            _addTuottaja = new RelayCommand(AddTuottaja);
            _removeTuottaja = new RelayCommand(RemoveTuottaja);
        }

        public void ViewTuottaja(object tuottaja)
        {
            var valmistaja = tuottaja as Tuottaja;
            ViewedTuottaja = valmistaja;
        }

        public void SelectTuottaja(object supplier)
        {
            var valmistaja = supplier as Tuottaja;
            TuottajaModel = valmistaja;
        }

        public void AddTuottaja()
        {
            
            AntaaId(TuottajaModel);

            
            Tuottajat.Add(TuottajaModel);
            
            Tallennukset.SaveUusiTuottaja(Tuottajat);
            ClearTuottaja();
        }


        public void UpdateTuottaja()
        {
            
            var valmistaja = Tuottajat.FirstOrDefault(param => param.Id == TuottajaModel.Id);
            
            valmistaja = TuottajaModel;
            
            Tallennukset.SaveUusiTuottaja(Tuottajat);
            ClearTuottaja();
        }

        public void RemoveTuottaja(object contact)
        {
            var vanhaTuottaja = contact as Tuottaja;
            Tuottajat.Remove(vanhaTuottaja);
            
            Tallennukset.SaveUusiTuottaja(Tuottajat);
        }


        public void ClearTuottaja()
        {
            TuottajaModel = new Tuottaja();
            OnPropertyChanged("TuottajaModel");
        }

        private void AntaaId(Tuottaja valmistaja)
        {
           
            valmistaja.Id = 0;
            if (Tuottajat.Count > 0)
            {
                
                valmistaja.Id = Tuottajat.Max(i => i.Id);
                valmistaja.Id++;
            }
        }



    }
}
