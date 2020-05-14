using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Application
    {
        private IFactory Country;
        public Application(IFactory Country)
        {
            this.Country = Country;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Language: " + Country.Language().Get());
            Console.WriteLine("Currency: " + Country.Currency().Get());
            Console.WriteLine("Capital: " + Country.City().Get());
            Console.WriteLine("Time Zone: " + Country.TimeZone().Get());
            Console.WriteLine("EMS Number: " + Country.EMSNumber().Get());
            Console.WriteLine("Population: " + Country.Population().Get());
            Console.WriteLine("Area: " + Country.Area().Get());
            Console.WriteLine("Date Format: " + Country.DateFormat().Get());
            Console.WriteLine("Calling Code: " + Country.CallingCode().Get());
            Console.WriteLine("ISO Code: " + Country.ISOCode().Get());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFactory Country;
            string line = "";
            Console.WriteLine("Enter your country:");
            line = Console.ReadLine();
            if (line == "Russia")
                Country = new RUFactory();
            else if (line == "Germany")
                Country = new DEFactory();
            else if (line == "China")
                Country = new CNFactory();
            else
                throw new Exception("Error! It is illegal to use this application in " + line);

            Application App = new Application(Country);
            App.PrintInfo();
        }
    }
}
