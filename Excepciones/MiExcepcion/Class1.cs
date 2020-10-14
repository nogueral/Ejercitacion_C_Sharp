using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExcepcion
{
    public class LeandroException : Exception
    {
        public LeandroException(string mensaje): base("El mensaje personalizado es: " + mensaje)
        {

        }
    }
}
