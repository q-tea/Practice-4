using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Немецкие настройки</summary>
    public class DESetting : IGet
    {
        /// <returns>
        /// Немецкий язык</returns>
        public string GetLanguage() => "German";
        /// <returns>
        /// Немецкая валюта</returns>
        public string GetCurrency() => "Euro";
        /// <returns>
        /// Немецкий город по умолчанию</returns>
        public string GetCity() => "Berlin";
        /// <returns>
        /// Немецкий часовой пояс по умолчанию</returns>
        public string GetTimeZone() => "+01";
        /// <returns>
        /// Немецкий номер скорой помощи</returns>
        public string GetEMSNumber() => "112";
        /// <returns>
        /// Население Германии</returns>
        public string GetPopulation() => "83149300";
        /// <returns>
        /// Площадь Германии</returns>
        public string GetArea() => "357022";
        /// <returns>
        /// Немецкий формат времени</returns>
        public string GetDateFormat() => "mm/dd/yyy";
        /// <returns>
        /// Немецкий добавочный номер</returns>
        public string GetCallingCode() => "+49";
        /// <returns>
        /// Немецкий ISO код</returns>
        public string GetISOCode() => "DE";
    }
}
