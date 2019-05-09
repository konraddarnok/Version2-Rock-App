using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App
{
    class Person
    {
        private string _name;
        private int _tlfnr;

        public Person()
        {
            _name = "Johnny";
            _tlfnr = 25836009;
        }

        public Person(string Name, int tlfnr)
        {
            _name = Name;
            _tlfnr = tlfnr;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int tlfnr
        {
            get { return _tlfnr; }
            set { _tlfnr = value; }
        }
    }
}
