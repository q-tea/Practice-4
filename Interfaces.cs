using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Базовый интерфейс, описывающий классы вывода параметров</summary>
    interface IGet
    {
        string GetLanguage();
        string GetCurrency();
        string GetCity();
        string GetTimeZone();
        string GetEMSNumber();
        string GetPopulation();
        string GetArea();
        string GetDateFormat();
        string GetCallingCode();
        string GetISOCode();
    }
    /// <summary>
    /// Интерфейс, описывающий Абстрактную фабрику</summary>
    interface IFactory
    {
        string Language();
        string Currency();
        string City();
        string TimeZone();
        string EMSNumber();
        string Population();
        string Area();
        string DateFormat();
        string CallingCode();
        string ISOCode();
    }
}
