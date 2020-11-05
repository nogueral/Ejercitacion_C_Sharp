using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MiClase
    {
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }

        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public MiClase(string mensaje)
        {
            try
            {
                MiClase auxClase = new MiClase();
            }
            catch (Exception e)
            {

                throw new UnaExcepcion(mensaje, e);
            }
        }
    }
}
