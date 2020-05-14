using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DEFactory : IFactory
    {
        public IGet Language() => new DELanguage();
        public IGet Currency() => new DECurrency();
        public IGet City() => new DECity();
        public IGet TimeZone() => new DETimeZone();
        public IGet EMSNumber() => new DEEMSNumber();
        public IGet Population() => new DEPopulation();
        public IGet Area() => new DEArea();
        public IGet DateFormat() => new DEDateFormat();
        public IGet CallingCode() => new DECallingCode();
        public IGet ISOCode() => new DEISOCode();
    }
    class RUFactory : IFactory
    {
        public IGet Language() => new RULanguage();
        public IGet Currency() => new RUCurrency();
        public IGet City() => new RUCity();
        public IGet TimeZone() => new RUTimeZone();
        public IGet EMSNumber() => new RUEMSNumber();
        public IGet Population() => new RUPopulation();
        public IGet Area() => new RUArea();
        public IGet DateFormat() => new RUDateFormat();
        public IGet CallingCode() => new RUCallingCode();
        public IGet ISOCode() => new RUISOCode();
    }
    class CNFactory : IFactory
    {
        public IGet Language() => new CNLanguage();
        public IGet Currency() => new CNCurrency();
        public IGet City() => new CNCity();
        public IGet TimeZone() => new CNTimeZone();
        public IGet EMSNumber() => new CNEMSNumber();
        public IGet Population() => new CNPopulation();
        public IGet Area() => new CNArea();
        public IGet DateFormat() => new CNDateFormat();
        public IGet CallingCode() => new CNCallingCode();
        public IGet ISOCode() => new CNISOCode();
    }
}