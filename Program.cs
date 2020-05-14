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
        private IGet Country;
        /// <summary>
        /// Конструктор класса</summary>
        /// <param name="Country">Название страны</param>
        public Application(IGet Country)
        {
            this.Country = Country;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Language: " + Country.GetLanguage());
            Console.WriteLine("Currency: " + Country.GetCurrency());
            Console.WriteLine("Capital: " + Country.GetCity());
            Console.WriteLine("Time Zone: " + Country.GetTimeZone());
            Console.WriteLine("EMS Number: " + Country.GetEMSNumber());
            Console.WriteLine("Population: " + Country.GetPopulation());
            Console.WriteLine("Area: " + Country.GetArea());
            Console.WriteLine("Date Format: " + Country.GetDateFormat());
            Console.WriteLine("Calling Code: " + Country.GetCallingCode());
            Console.WriteLine("ISO Code: " + Country.GetISOCode());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IGet Country;
            string line = "";
            Console.WriteLine("Enter your country:");
            line = Console.ReadLine().ToLower();
            if ((line == "russia") || (line == "россия"))
                Country = new RUSetting();
            else if (line == "germany")
                Country = new DESetting();
            else if (line == "china")
                Country = new CNSetting();
            else
                throw new Exception("Error! It is illegal to use this application in " + line);

            Application App = new Application(Country);
            App.PrintInfo();
        }
    }
}
