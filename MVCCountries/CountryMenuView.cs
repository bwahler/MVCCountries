using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryMenuView
    {
        public static string CountryPick()
        {
            Console.WriteLine("What continent would you like to learn about?");
            string input = Console.ReadLine();

            return input;
        }

        public static string CountrySelect()
        {
            Console.WriteLine("What country would you like to learn about?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
