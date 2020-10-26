using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
     class Colibri : Animal
    {

        public Colibri(string nombre,int peso):base(nombre,peso)
        {

        }

        public override void Alimentarse()
        {
            Console.WriteLine("El colibri se esta alimentando");
        }



    }
}
