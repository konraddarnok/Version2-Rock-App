using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App.Model
{
    class genre
    {
        private string _pop;
        private string _rock;
        private string _heavyMetal;

        public Genre (string pop, string rock, string heavyMetal)
        {
            Pop = pop;
            Rock = rock;
            HeavyMetal = heavyMetal;
            
        }
        public string Pop { get; set; }
        public string Rock { get; set; }
        public string HeavyMetal { get; set; }
        
    }

}
