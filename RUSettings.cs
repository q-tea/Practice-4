using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Русский язык</summary>
    class RULanguage : IGet
    {
        public string Get() => "Russian";
    }
    /// <summary>
    /// Русская валюта</summary>
    class RUCurrency : IGet
    {
        public string Get() => "Ruble";
    }
    /// <summary>
    /// Дефолтный город России</summary>
    class RUCity : IGet
    {
        public string Get() => "Moscow";
    }
    /// <summary>
    /// Дефолтный часовой пояс России</summary>
    class RUTimeZone : IGet
    {
        public string Get() => "+03";
    }
    /// <summary>
    /// Русский номер скорой помощи</summary>
    class RUEMSNumber : IGet
    {
        public string Get() => "103";
    }
    /// <summary>
    /// Население России</summary>
    class RUPopulation : IGet
    {
        public string Get() => "146745098";
    }
    /// <summary>
    /// Площадь России</summary>
    class RUArea : IGet
    {
        public string Get() => "17098246";
    }
    /// <summary>
    /// Русский вормат даты</summary>
    class RUDateFormat : IGet
    {
        public string Get() => "dd.mm.yyyy";
    }
    /// <summary>
    /// Русский добавочный номер</summary>
    class RUCallingCode : IGet
    {
        public string Get() => "+7";
    }
    /// <summary>
    /// Русский ISO код</summary>
    class RUISOCode : IGet
    {
        public string Get() => "RU";
    }
}
