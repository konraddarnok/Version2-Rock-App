using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version2_Rock_App;

namespace Version2_Rock_App.Model
{

    

    public class Artefakter
    {
        private int _aId;
        private string _name;
        private int _year;
        private string _description;
        private string _pic;


        public Artefakter(int aId, string name, int year, string description, string pic)
        {
            _aId = aId;
            _name = name;
            _year = year;
            _description = description;
            _pic = pic;
        }

        public int aId
        {
            get { return aId;}
            set { _aId = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string description
        {
            get { return _description;}
            set { _description = value; }
        }

        public string pic
        {
            get { return _pic; }
            set { _pic = value; }
        }

    }
    
    



}
