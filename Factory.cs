using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Класс немецкой фабрики</summary>
    class DEFactory : IFactory
    {
        public string Language() => new DESetting().GetLanguage();
        public string Currency() => new DESetting().GetCurrency();
        public string City() => new DESetting().GetCity();
        public string TimeZone() => new DESetting().GetTimeZone();
        public string EMSNumber() => new DESetting().GetEMSNumber();
        public string Population() => new DESetting().GetPopulation();
        public string Area() => new DESetting().GetArea();
        public string DateFormat() => new DESetting().GetDateFormat();
        public string CallingCode() => new DESetting().GetCallingCode();
        public string ISOCode() => new DESetting().GetISOCode();
    }
    /// <summary>
    /// Класс русской фабрики</summary>
    class RUFactory : IFactory
    {
        public string Language() => new RUSetting().GetLanguage();
        public string Currency() => new RUSetting().GetCurrency();
        public string City() => new RUSetting().GetCity();
        public string TimeZone() => new RUSetting().GetTimeZone();
        public string EMSNumber() => new RUSetting().GetEMSNumber();
        public string Population() => new RUSetting().GetPopulation();
        public string Area() => new RUSetting().GetArea();
        public string DateFormat() => new RUSetting().GetDateFormat();
        public string CallingCode() => new RUSetting().GetCallingCode();
        public string ISOCode() => new RUSetting().GetISOCode();
    }
    /// <summary>
    /// Класс китайской фабрики</summary>
    class CNFactory : IFactory
    {
        public string Language() => new CNSetting().GetLanguage();
        public string Currency() => new CNSetting().GetCurrency();
        public string City() => new CNSetting().GetCity();
        public string TimeZone() => new CNSetting().GetTimeZone();
        public string EMSNumber() => new CNSetting().GetEMSNumber();
        public string Population() => new CNSetting().GetPopulation();
        public string Area() => new CNSetting().GetArea();
        public string DateFormat() => new CNSetting().GetDateFormat();
        public string CallingCode() => new CNSetting().GetCallingCode();
        public string ISOCode() => new CNSetting().GetISOCode();
    }
}