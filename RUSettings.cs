using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Русские настройки</summary>
    class RUSetting : IGet
    {
        /// <returns>
        /// Русский язык</returns>
        public string GetLanguage() => "Russian";
        /// <returns>
        /// Русская валюта</returns>
        public string GetCurrency() => "Ruble";
        /// <returns>
        /// Дефолтный город России</returns>
        public string GetCity() => "Moscow";
        /// <returns>
        /// Дефолтный часовой пояс России</returns>
        public string GetTimeZone() => "+03";
        /// <returns>
        /// Русский номер скорой помощи</returns>
        public string GetEMSNumber() => "103";
        /// <returns>
        /// Население России</returns>
        public string GetPopulation() => "146745098";
        /// <returns>
        /// Площадь России</returns>
        public string GetArea() => "17098246";
        /// <returns>
        /// Русский вормат даты</returns>
        public string GetDateFormat() => "dd.mm.yyyy";
        /// <returns>
        /// Русский добавочный номер</returns>
        public string GetCallingCode() => "+7";
        /// <returns>
        /// Русский ISO код</returns>
        public string GetISOCode() => "RU";
    }
}
