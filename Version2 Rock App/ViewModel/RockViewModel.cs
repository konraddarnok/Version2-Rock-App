using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Version2_Rock_App.Model;
using Version2_Rock_App.Relay;

namespace Version2_Rock_App.ViewModel
{
    class RockViewModel : INotifyPropertyChanged
    {

        private artefaktkatalog katalog;

        public RockViewModel()
        {
            _selectedArtefakt = new Artefakter();
          katalog = new artefaktkatalog();
        }


        private Artefakter _selectedArtefakt;
        private object catalog;

        public Artefakter SelectArtefakt
        {
            get { return _selectedArtefakt; }
            set { _selectedArtefakt = value; OnPropertyChanged(); }
        }


       

        public artefaktkatalog SelectArtefaktkatalog
        {
            get {
                return katalog;}
            set {
               katalog = value; OnPropertyChanged();
            }
            
        }


        public ObservableCollection<Artefakter> All_artefacts
        {
            get
            {
                ObservableCollection<Artefakter> collection = new ObservableCollection<Artefakter>(katalog.Artefakter);
                return collection;


            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged
            ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new
                PropertyChangedEventArgs(propertyName));
        } 
        
        

    }
}
