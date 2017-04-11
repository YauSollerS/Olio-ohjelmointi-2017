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
    public class TuotteetViewModel : ObservableObject
    {
        private ObservableCollection<Tuote> _tuoteList { get; set; }

        public ObservableCollection<Tuote> Tuotteet { get; set; }

        public ObservableCollection<Tuottaja> Valmistajat { get; set; }

        private Tuote _tuoteModel { get; set; }

        private Tuote _viewedTuote { get; set; }

        private Tuottaja _selectedValmistaja { get; set; }


        public Tuote TuoteModel
        {
            get
            {
                return _tuoteModel; 
            }
            set
            {
                _tuoteModel = value;
                OnPropertyChanged("TuoteModel");
            }
        }

        public Tuottaja SelectedValmistaja
        {
            get
            {
                return _selectedValmistaja;
            }
            set
            {
                _selectedValmistaja = value;
                
                TuoteModel.ValmistajaId = _selectedValmistaja.Id;
                OnPropertyChanged("SelectedValmistaja");
            }
        }

        public Tuote ViewedTuote
        {
            get { return _viewedTuote; }
            set
            {
                _viewedTuote = value;

                if (value != null && Valmistajat.Count > 0)
                {
                    
                    var valmistaja = Valmistajat.FirstOrDefault(param => param.Id == _viewedTuote.ValmistajaId);
                    
                    if (valmistaja != null) _viewedTuote.ValmistajaNimi = valmistaja.Nimi;
                }

                OnPropertyChanged("ViewedTuote");
            }
        }

        private ICommand _editTuote { get; set; }
        public ICommand EditCommand
        {
            get
            {
                return _editTuote;
            }
        }

        private ICommand _cancleEdit { get; set; }
        public ICommand CancleCommand
        {
            get
            {
                return _cancleEdit;
            }
        }

        private ICommand _updateTuote { get; set; }
        public ICommand UpdateCommand
        {
            get
            {
                return _updateTuote;
            }
        }

        private ICommand _addTuote { get; set; }
        public ICommand AddCommand
        {
            get
            {
                return _addTuote;
            }
        }

        private ICommand _removeTuote { get; set; }
        public ICommand RemoveCommand
        {
            get
            {
                return _removeTuote;
            }
        }

        public TuotteetViewModel()
        {
            _tuoteList = Tallennukset.LoadTuoteList();
            Tuotteet = _tuoteList;
            Valmistajat = Tallennukset.LoadTuottajat();
            TuoteModel = new Tuote();
            
            SelectedValmistaja = new Tuottaja();

            _editTuote = new RelayCommand(EditTuote);
            _addTuote = new RelayCommand(AddTuote);
            _removeTuote = new RelayCommand(RemoveTuote);
            _cancleEdit = new RelayCommand(Cancle);
            _updateTuote = new RelayCommand(Update);
        }

        public void EditTuote(object tuote)
        {
            TuoteModel = tuote as Tuote;
            SelectedValmistaja.Id = TuoteModel.ValmistajaId;

            SelectedValmistaja = Valmistajat.FirstOrDefault(c => c.Id == TuoteModel.ValmistajaId) ?? Valmistajat[0];

            OnPropertyChanged("TuoteModel");

        }

        public void AddTuote()
        {
            AntaaId(TuoteModel);
            
            _tuoteList.Add(TuoteModel);

            Update();
        }

        public void RemoveTuote(object tuote)
        {
            var vanhaTuote = tuote as Tuote;
            _tuoteList.Remove(vanhaTuote);
            Update();
        }

        public void Update()
        {
            TuoteModel = new Tuote();
            Tallennukset.SaveUusiTuoteList(_tuoteList);
        }

        public void Cancle()
        {
            TuoteModel = new Tuote();
        }

        private void AntaaId(Tuote tuote)
        {
            tuote.Id = 100;
            if(Tuotteet.Count>0)
            {
                tuote.Id = Tuotteet.Max(i => i.Id);
                tuote.Id++;
            }
        }
    }
}
