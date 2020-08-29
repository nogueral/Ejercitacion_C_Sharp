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

            int altura;

            Console.Write("Ingrese la altura de la torre: ");
            altura = int.Parse(Console.ReadLine());
            string aux;

            altura = altura * 2;

            Console.WriteLine();

            for (int i = 1; i <= altura; i += 2)
            {
                aux = "";

                for (int j = 1; j <= i; j++)
                {
                    aux += "*";
                }

                Console.Write("{0,10}", aux);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
