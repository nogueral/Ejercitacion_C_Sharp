using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_9
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 9";

            int altura;

            Console.Write("Ingrese la altura de la torre: ");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= (altura*2); i+=2)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
