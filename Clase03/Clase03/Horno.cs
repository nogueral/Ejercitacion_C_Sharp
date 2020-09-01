using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Horno
    {
        public Galletita[] galletitas;
        static bool Hornear(Galletita[] galletitas)
        {
            foreach (Galletita item in galletitas)
            {
                item.Hornear();
            }

           

            return true;
        }

        public Horno()
        {
            this.galletitas = new Galletita[5];
        }
    }
}
