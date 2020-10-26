using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    abstract class SerVivo
    {
        protected string nombre;
        protected int peso;


        public SerVivo(string nombre, int peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }


        public abstract void Alimentarse();

    }
}
