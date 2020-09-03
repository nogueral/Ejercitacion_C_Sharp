using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    class Conversor
    {
        public static int BinarioDecimal (string binario)
        {
            int nroDecimal = 0;
            int digito;
            string copia;
            int contador = 0;
            int largo = binario.Length;

            largo -= 1;

            for (int i = binario.Length; i >= 0; i--)
            {

                copia = binario.Remove(contador, largo);
                contador++;
                if (int.TryParse(copia, out digito))
                {
                    nroDecimal += (int) Math.Pow(digito * 2, i);
                }
                
            }


            return nroDecimal;
        }
    }
}
