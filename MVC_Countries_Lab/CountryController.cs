using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    public class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA", "North America", "Red", "White", "Blue"),
            new Country("Germany", "Europe", "Red","Black", "Yellow"),
            new Country("France", "Europe", "Red", "White", "Blue"),
            new Country("Mexico", "North America", "Red", "White","Green"),
            new Country("China", "Asia", "Red", "Yellow"),
            new Country("Brazil", "South America", "Green", "Yellow", "Blue"),
            new Country("Egypt", "Africa", "Red", "White", "Black"),
            new Country("India", "Asia", "Darkyellow", "White", "Green")
        };



        public void CountryAction(Country c)
        {
            CountryView list = new CountryView(c);

            list.Display();


        }
        public void WelcomeAction()
        {
            bool runProgram = true;
            while (runProgram == true)
            {

                CountryListView ListView = new CountryListView(CountryDb);

                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list");

                ListView.Display();
                while (true)
                {

                    Console.WriteLine("Please choose a country by number");
                    int choice = int.Parse(Console.ReadLine());

                    Country c = CountryDb[choice];

                    CountryAction(c);
                    Console.WriteLine("Would you like to learn about another country?y/n");
                    string response = Console.ReadLine().ToLower().Trim();

                    if (response == "y")
                    {
                        break;
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine("goodbye");
                        runProgram = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter y or n.");
                    }

                }

            }

        }
    }
}

