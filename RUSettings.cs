using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class RULanguage : IGet
    {
        public string Get() => "Russian";
    }
    class RUCurrency : IGet
    {
        public string Get() => "Ruble";
    }
    class RUCity : IGet
    {
        public string Get() => "Moscow";
    }
    class RUTimeZone : IGet
    {
        public string Get() => "+03";
    }
    class RUEMSNumber : IGet
    {
        public string Get() => "103";
    }
    class RUPopulation : IGet
    {
        public string Get() => "146745098";
    }
    class RUArea : IGet
    {
        public string Get() => "17098246";
    }
    class RUDateFormat : IGet
    {
        public string Get() => "dd.mm.yyyy";
    }
    class RUCallingCode : IGet
    {
        public string Get() => "+7";
    }
    class RUISOCode : IGet
    {
        public string Get() => "RU";
    }
}
