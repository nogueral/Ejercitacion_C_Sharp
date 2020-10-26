using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    class Lobo : Animal
    {

        public Lobo(string nombre, int peso) : base(nombre, peso) 
        {

        }


        public override void Alimentarse()
        {
            Console.WriteLine("El lobo se esta alimentando");
        }

    }
}
