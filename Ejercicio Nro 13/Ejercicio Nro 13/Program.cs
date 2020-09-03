using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario = "1100";

            Console.WriteLine("Numero decimal: {0}", Conversor.BinarioDecimal(binario));
        }
    }
}
