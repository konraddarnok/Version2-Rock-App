using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Version2_Rock_App.Model;

namespace Version2_Rock_App.ViewModel
{
    class RockViewModel : INotifyPropertyChanged
    {

        private artefaktkatalog _selectedkatalog;

        public RockViewModel()
        {
            _selectedArtefakt = new Artefakter();
          _selectedkatalog = new artefaktkatalog();
        }

        private Artefakter _selectedArtefakt;
        public Artefakter SelectArtefakt
        {
            get { return _selectedArtefakt; }
            set { _selectedArtefakt = value; OnPropertyChanged(); }
        }


        public artefaktkatalog SelectArtefaktkatalog
        {
            get {
                return _selectedkatalog;          }
            set {
                _selectedkatalog = value; OnPropertyChanged();
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
