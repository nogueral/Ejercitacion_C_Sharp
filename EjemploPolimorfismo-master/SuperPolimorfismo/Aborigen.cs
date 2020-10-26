using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    class Aborigen : Humano
    {

        public Aborigen(string nombre, int peso, string apellido) : base(nombre, peso, apellido)
        {
        }

        public override void Alimentarse()
        {
            throw new NotImplementedException();
        }
    }
}
