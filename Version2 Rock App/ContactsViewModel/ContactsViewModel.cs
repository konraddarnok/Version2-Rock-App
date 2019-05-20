using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App
{
    class ContactsViewModel : INotifyPropertyChanged
    {
        private string _name;
        private int _tlfnr;
        private ContactsList contactlist;
        
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

        public ContactsViewModel()
        {
            _selectedPerson= new Person();
            contactlist = new ContactsList();
            DeleteCommand = new RelayCommand(toDeletePerson);
            AddCommand = new RelayCommand(toAddPerson);
        }

        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand AddCommand { get; set; }

        public void toAddPerson()
        {
            Person NewPerson= new Person(_name, _tlfnr);
            contactlist.addPerson(NewPerson);
            OnPropertyChanged(nameof(All_Persons));
        }

        public void toDeletePerson()
        {
            contactlist.removePerson(SelectedPerson);
            OnPropertyChanged(nameof(All_Persons));
        }

        private Person _selectedPerson;

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Person> All_Persons
        {
            get
            {
                ObservableCollection<Person> collection = new ObservableCollection<Person>(contactlist.Persons);
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
