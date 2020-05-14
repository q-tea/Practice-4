using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Класс приложения.
    /// </summary>
    class Application
    {
        private IFactory Country;
        /// <summary>
        /// Конструктор класса</summary>
        /// <param name="Country">Название страны</param>
        public Application(IFactory Country)
        {
            this.Country = Country;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Language: " + Country.Language());
            Console.WriteLine("Currency: " + Country.Currency());
            Console.WriteLine("Capital: " + Country.City());
            Console.WriteLine("Time Zone: " + Country.TimeZone());
            Console.WriteLine("EMS Number: " + Country.EMSNumber());
            Console.WriteLine("Population: " + Country.Population());
            Console.WriteLine("Area: " + Country.Area());
            Console.WriteLine("Date Format: " + Country.DateFormat());
            Console.WriteLine("Calling Code: " + Country.CallingCode());
            Console.WriteLine("ISO Code: " + Country.ISOCode());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFactory Country;
            string line = "";
            Console.WriteLine("Enter your country:");
            line = Console.ReadLine().ToLower();
            if ((line == "russia") || (line == "россия"))
                Country = new RUFactory();
            else if (line == "germany")
                Country = new DEFactory();
            else if (line == "china")
                Country = new CNFactory();
            else
                throw new Exception("Error! It is illegal to use this application in " + line);

            Application App = new Application(Country);
            App.PrintInfo();
        }
    }
}
