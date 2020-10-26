using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    class Jirafa: Animal
    {
        public Jirafa(string nombre, int peso) : base(nombre, peso)
        {

        }

        public override void Alimentarse()
        {
            Console.WriteLine("La jirafa se esta alimentando");
        }
    }
}
