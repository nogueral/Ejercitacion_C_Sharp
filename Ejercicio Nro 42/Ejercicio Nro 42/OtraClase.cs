using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                MiClase auxMiClase = new MiClase("Excepcion Una Excepcion");
            }
            catch (Exception e)
            {

                throw new MiExcepcion("Excepcion Mi Excepcion", e);
            }
        }
    }
}
