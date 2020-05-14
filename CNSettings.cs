using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Китайский язык</summary>
    class CNLanguage : IGet
    {
        public string Get() => "Chinese";
    }
    /// <summary>
    /// Китайская валюта</summary>
    class CNCurrency : IGet
    {
        public string Get() => "Yuan";
    }
    /// <summary>
    /// Дефолтный китайский город</summary>
    class CNCity : IGet
    {
        public string Get() => "Beijing";
    }
    /// <summary>
    /// Дефолтный китайский часовой пояс</summary>
    class CNTimeZone : IGet
    {
        public string Get() => "+08";
    }
    /// <summary>
    /// Номер скорой помощи Китая</summary>
    class CNEMSNumber : IGet
    {
        public string Get() => "120";
    }
    /// <summary>
    /// Население Китая</summary>
    class CNPopulation : IGet
    {
        public string Get() => "1427647786";
    }
    /// <summary>
    /// Площадь Китая</summary>
    class CNArea : IGet
    {
        public string Get() => "9596961";
    }
    /// <summary>
    /// Формат времени Китая </summary>
    class CNDateFormat : IGet
    {
        public string Get() => "yyyy-mm-dd";
    }
    /// <summary>
    /// Добавочный номер Китая</summary>
    class CNCallingCode : IGet
    {
        public string Get() => "+86";
    }
    /// <summary>
    /// Китайский ISO код</summary>
    class CNISOCode : IGet
    {
        public string Get() => "CN";
    }
}
