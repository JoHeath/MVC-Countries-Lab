using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    public class Country
    {
        //properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string>Colors { get; set; }

        //constructor
        public Country(string _name, string _continent, params string[] _colors)
        {
            Name = _name;
            Continent = _continent;
            Colors = _colors.ToList();
        }
    }
}
