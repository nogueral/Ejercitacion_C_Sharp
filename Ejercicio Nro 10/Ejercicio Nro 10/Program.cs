using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            Console.WriteLine("Ingrese la altura de la piramide");
            int altura = int.Parse(Console.ReadLine());
            char asterisco = '*';

            for (int i = 0; i <= altura; i++)
            {
                for (int j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(asterisco);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
