using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App.Model
{
    class Artist
    {
        private string _name;
        private int _year;
        private string _album;
        private string _description;

        public Artist(string name, int year, string album, string description)
        {
            Name = name;
            Year = year;
            Album = album;
            Description = description;
        }

        public string Name { get; set; }
        public int Year { get => _year; set => _year = value; }
        public string Album { get => _album; set => _album = value; }
        public string Description { get => _description; set => _description = value; }


        
    }
}
