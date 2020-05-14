using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Немецкий язык</summary>
    class DELanguage : IGet
    {
        public string Get() => "German";
    }
    /// <summary>
    /// Немецкая валюта</summary>
    class DECurrency : IGet
    {
        public string Get() => "Euro";
    }
    /// <summary>
    /// Дефолтный город Германии</summary>
    class DECity : IGet
    {
        public string Get() => "Berlin";
    }
    /// <summary>
    /// Часовой пояс Германии</summary>
    class DETimeZone : IGet
    {
        public string Get() => "+01";
    }
    /// <summary>
    /// Немецкий номер скорой помощи</summary>
    class DEEMSNumber : IGet
    {
        public string Get() => "112";
    }
    /// <summary>
    /// Население Германии</summary>
    class DEPopulation : IGet
    {
        public string Get() => "83149300";
    }
    /// <summary>
    /// Площадь Германии</summary>
    class DEArea : IGet
    {
        public string Get() => "357022";
    }
    /// <summary>
    /// Немеций вормат даты</summary>
    class DEDateFormat : IGet
    {
        public string Get() => "mm/dd/yyy";
    }
    /// <summary>
    /// Немецкий добавочный номер</summary>
    class DECallingCode : IGet
    {
        public string Get() => "+49";
    }
    /// <summary>
    /// Немецкий ISO код</summary>
    class DEISOCode : IGet
    {
        public string Get() => "DE";
    }
}
