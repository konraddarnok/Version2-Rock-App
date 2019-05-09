using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App
{
    class ContactsViewModel:INotifyPropertyChanged
    {
        private string _name;
        private int _tlfnr;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int TlfNr
        {
            get { return _tlfnr; }
            set { _tlfnr = value; }
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
