using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario bin = new NumeroBinario("10");
            NumeroDecimal dec = new NumeroDecimal(5);

            Console.WriteLine(bin + dec);

            dec = (NumeroDecimal)bin;

            Console.WriteLine(dec.GetNumero());
        }
    }
}
