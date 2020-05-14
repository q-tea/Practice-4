using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DELanguage : IGet
    {
        public string Get() => "German";
    }
    class DECurrency : IGet
    {
        public string Get() => "Euro";
    }
    class DECity : IGet
    {
        public string Get() => "Berlin";
    }
    class DETimeZone : IGet
    {
        public string Get() => "+01";
    }
    class DEEMSNumber : IGet
    {
        public string Get() => "112";
    }
    class DEPopulation : IGet
    {
        public string Get() => "83149300";
    }
    class DEArea : IGet
    {
        public string Get() => "357022";
    }
    class DEDateFormat : IGet
    {
        public string Get() => "mm/dd/yyy";
    }
    class DECallingCode : IGet
    {
        public string Get() => "+49";
    }
    class DEISOCode : IGet
    {
        public string Get() => "DE";
    }
}
