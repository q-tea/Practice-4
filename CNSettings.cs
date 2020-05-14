using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Китайский язык</summary>
    class CNSetting : IGet
    {
        public string GetLanguage() => "Chinese";
        /// <returns>
        /// Китайская валюта</returns>
        public string GetCurrency() => "Yuan";
        /// <returns>
        /// Дефолтный китайский город</returns>
        public string GetCity() => "Beijing";
        /// <returns>
        /// Дефолтный китайский часовой пояс</returns>
        public string GetTimeZone() => "+08";
        /// <returns>
        /// Номер скорой помощи Китая</returns>
        public string GetEMSNumber() => "120";
        /// <returns>
        /// Население Китая</returns>
        public string GetPopulation() => "1427647786";
        /// <returns>
        /// Площадь Китая</returns>
        public string GetArea() => "9596961";
        /// <returns>
        /// Формат времени Китая </returns>
        public string GetDateFormat() => "yyyy-mm-dd";
        /// <returns>
        /// Добавочный номер Китая</returns>
        public string GetCallingCode() => "+86";
        /// <returns>
        /// Китайский ISO код</returns>
        public string GetISOCode() => "CN";
    }
}
