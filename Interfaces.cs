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
        string Get();
    }
    /// <summary>
    /// Интерфейс, описывающий Абстрактную фабрику</summary>
    interface IFactory
    {
        IGet Language();
        IGet Currency();
        IGet City();
        IGet TimeZone();
        IGet EMSNumber();
        IGet Population();
        IGet Area();
        IGet DateFormat();
        IGet CallingCode();
        IGet ISOCode();
    }
}
