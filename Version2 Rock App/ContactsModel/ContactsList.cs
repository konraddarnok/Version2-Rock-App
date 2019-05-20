using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App
{
    class ContactsList
    {
        private List<Person> _persons;

        public ContactsList()
        {
            _persons = new List<Person>();
        }

        public void removePerson(Person p)
        {
            _persons.Remove(p);
        }

        public void addPerson(Person np)
        {
            bool exist = false;
            if (_persons != null)
            {
                foreach (var p in _persons)
                {
                    if (p.tlfnr == np.tlfnr)
                        exist = true;
                }
                if (exist == false)
                    _persons.Add(np);
            }
        }

        public List<Person> Persons
        {
            get { return _persons; }
        }

        public async Task SaveAsync()
        {
            await _fileSource.SaveAsync(_persons);
        }

        public async Task <List<Person>> loadAsync()
        {
            _persons = await _fileSource.LoadAsync();
            return _persons;
        }
    }
}
