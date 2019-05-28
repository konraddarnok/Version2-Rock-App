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
        private int qaId;
        private string qname;
        private int qyear;
        private string qdescription;
        private string qpic;
        private int qIdCount = 1;

        public Artefakter()
        {
            qaId = 1;
            qname = "Artefakt1";
            qdescription = "beskrivelse1";
            qpic = "pic5";
            qyear = 1990;
           

        }

        public Artefakter(int aId, string name, int year, string description, string pic)
        {
            qaId = aId;
            qname = name;
            qyear = year;
            qdescription = description;
            qpic = pic;
            qIdCount++;

        }

        public int aId
        {
            get { return aId;}
            set { qaId = value; }
        }

        public string name
        {
            get { return qname; }
            set { qname = value; }
        }

        public int year
        {
            get { return qyear; }
            set { qyear = value; }
        }

        public string description
        {
            get { return qdescription;}
            set { qdescription = value; }
        }

        public string pic
        {
            get { return qpic; }
            set { qpic = value; }
        }
      

    }
    
    



}
