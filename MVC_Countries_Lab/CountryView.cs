using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    public class CountryView
    {
        //properties
        public Country DisplayCountry { get; set; }

        //constructor

        public CountryView (Country _country)
        {
            DisplayCountry = _country;
        }

        //methods
        public void Display()
        {
            Console.Write($"Name {DisplayCountry.Name} {DisplayCountry.Continent} " );
            foreach(string c in DisplayCountry.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(c);
                Console.Write($"{c} ");
            }   
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
