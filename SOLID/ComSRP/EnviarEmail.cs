using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP.ComSRP
{
    internal class EnviarEmail
    {
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; } 


        public void Enviar()
        {
            
        }
    }
}
