using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version2_Rock_App;

namespace Version2_Rock_App.Model
{
    public class artefaktkatalog 
    {
        private List<Artefakter> _artefakter;

        public artefaktkatalog()
        {
           _artefakter = new List<Artefakter>();
           new Artefakter(1, "Lys", 1990, "Lad der blive lys", "pic1");
           new Artefakter(2, "Musikkalske strømme", 2000, "Musik tendenser fra 2000", "pic2");
           new Artefakter(3, "Dansefeber", 2000, "Lad at danse som i året 2000", "pic3");
           new Artefakter(4, "Fankultur", 2000, "Læs om hvor fan kulturen var blandt drenge og piger", "pic4");
        }

        
    }
}
