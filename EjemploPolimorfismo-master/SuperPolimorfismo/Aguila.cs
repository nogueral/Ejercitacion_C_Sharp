using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    class Aguila : Animal, IVolador
    {

        public Aguila(string nombre, int peso) : base(nombre, peso) 
        {

        }

        public string EnElAire {

            get { return "ñami ñami,estoy mirando que encuentro en el aire"; }
        }

        public override void Alimentarse()
        {
            Console.WriteLine("ÑAAAAAM");
        }

        public void Moverse()
        {
            Console.WriteLine(" bruu bruuu bruuu ( ruido de alas moviendose)");
        }

        public void Volar()
        {
            Console.WriteLine("Surco el aire re piola");
        }
    }
}
