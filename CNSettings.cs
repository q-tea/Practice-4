using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CNLanguage : IGet
    {
        public string Get() => "Chinese";
    }
    class CNCurrency : IGet
    {
        public string Get() => "Yuan";
    }
    class CNCity : IGet
    {
        public string Get() => "Beijing";
    }
    class CNTimeZone : IGet
    {
        public string Get() => "+08";
    }
    class CNEMSNumber : IGet
    {
        public string Get() => "120";
    }
    class CNPopulation : IGet
    {
        public string Get() => "1427647786";
    }
    class CNArea : IGet
    {
        public string Get() => "9596961";
    }
    class CNDateFormat : IGet
    {
        public string Get() => "yyyy-mm-dd";
    }
    class CNCallingCode : IGet
    {
        public string Get() => "+86";
    }
    class CNISOCode : IGet
    {
        public string Get() => "CN";
    }
}
