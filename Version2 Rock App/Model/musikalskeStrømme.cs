using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Version2_Rock_App.Model
{
    class Musikalske_strømme
    {
        private string _aarti;
        private string _sang;
        private string _kunstner;

        public Musikalske_strømme(string aarti, string sang, string kunstner)
        {
            Aarti = aarti;
            Sang = sang;
            Kunstner = kunstner;
           }
        public string Aarti { get; set; }
        public string Sang { get; set; }
        public string Kunstner { get; set; }
    }
}
