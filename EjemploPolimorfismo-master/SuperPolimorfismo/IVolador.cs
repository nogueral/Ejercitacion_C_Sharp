using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    interface IVolador
    {

        string EnElAire { get; } // prop


        void Volar();  // metodo

        void Moverse();
    }
}
