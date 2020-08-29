using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_4
{
    class Program
    {
        /*Escribir una app que encuentre los 4 primeros nros perfectos*/

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            int contador = 0;
            int numero = 6;
            bool numeroPerfecto;

            do
            {
                numeroPerfecto = ValidarPerfecto(numero);

                if (numeroPerfecto == true)
                {
                    Console.WriteLine($"El numero {numero} es perfecto");
                    contador++;
                }

                numero++;

            } while (contador < 4);

            Console.ReadKey();
        }

        static bool ValidarPerfecto(int param)
        {
            bool retorno = false;
            int acumulador = 0;

            for (int i = 1; i < param; i++)
            {
                if (param % i == 0)
                    acumulador += i;
            }

            if (acumulador == param)
                retorno = true;

            return retorno;
        }
    }
}
