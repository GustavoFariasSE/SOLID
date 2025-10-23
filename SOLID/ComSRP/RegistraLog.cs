using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP.ComSRP
{
    internal class RegistraLog : ILogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
