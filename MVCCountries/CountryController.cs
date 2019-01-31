using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }

        public void CountryMenu()
        {
            bool run = true;
            while (run == true)
            {
                List<string> countryNames = new List<string>();
                List<Country> countries;
                string input = CountryMenuView.CountryPick();
                if (input.ToLower() == "north america")
                {
                    NorthAmericaDB nadb = new NorthAmericaDB();
                    countries = nadb.Countries;
                    foreach (Country c in countries)
                    {
                        countryNames.Add(c.Name);
                        Console.WriteLine(c.Name);
                    }
                    
                    string input2 = CountryMenuView.CountrySelect();
                    if (input2.ToLower() == "usa")
                    {
                        foreach (Country c in countries)
                        {
                            if(c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "mexico")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "canada")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                }
                if (input.ToLower() == "asia")
                {
                    AsiaDB adb = new AsiaDB();
                    countries = adb.Countries;
                    foreach (Country c in countries)
                    {
                        countryNames.Add(c.Name);
                        Console.WriteLine(c.Name);
                    }
 
                    string input2 = CountryMenuView.CountrySelect();
                    if (input2.ToLower() == "china")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "japan")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "vietnam")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "north korea")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                    else if (input2.ToLower() == "south korea")
                    {
                        foreach (Country c in countries)
                        {
                            if (c.Name.ToLower() == input2)
                            {
                                CountryDetails cc = new CountryDetails(c);
                                cc.Display();
                            }
                        }
                    }
                }
                run = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would like to continue? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool run;
            if(userContinue == "y")
            {
                run = true;
            }
            else if(userContinue == "n")
            {
                run = false;
            }
            else
            {
                run = Continue();
            }
            return run;
        }
    }
}
