using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App.Model
{
    class Person
    {
        private string _name;
        private int _telephonenumber;

        public Person()
        {
            _name = "Johnny";
            _telephonenumber = 25836009;
        }

        public Person(string Name, int telephonenumber)
        {
            _name = Name;
            _telephonenumber = telephonenumber;
        }

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
    }
}
