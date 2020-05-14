using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IGet
    {
        string Get();
    }
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
