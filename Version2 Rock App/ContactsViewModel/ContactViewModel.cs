using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Version2_Rock_App.Common;
using Version2_Rock_App.Model;

namespace Version2_Rock_App.ContactsViewModel
{
    class ContactViewModel : INotifyPropertyChanged
    {
        private string _name;
        private int _telephonenumber;
        private ContactsList contactlist;
        private int _generaltelephonenumber;
        private string _webaddress;
        private string _complaintwebaddress;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int TelephoneNumber
        {
            get { return _telephonenumber; }
            set { _telephonenumber = value; }
        }

        public int GeneralTelephoneNumber
        {
            get { return _generaltelephonenumber; }
            set { _generaltelephonenumber = value; }
        }

        public string WebAddress
        {
            get { return _webaddress; }
            set { _webaddress = value; }
        }

        public string ComplaintWebAddress
        {
            get { return _complaintwebaddress; }
            set { _complaintwebaddress = value; }
        }

        public ContactViewModel()
        {
            _selectedPerson = new Person();
            contactlist = new ContactsList();
            DeleteCommand = new RelayCommand(toDeletePerson);
            AddCommand = new RelayCommand(toAddPerson);
        }

        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand AddCommand { get; set; }

        public void toAddPerson()
        {
            Person NewPerson = new Person(_name, _telephonenumber);
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
