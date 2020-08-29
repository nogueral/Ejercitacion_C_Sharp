using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_3
{
    class Program
    {
        /*Mostrar todos los nros primos hasta el nro ingresado x consola*/

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            
            int numeroIngresado;
            bool retorno;

            Console.WriteLine("Por favor, ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroIngresado; i++)
            {
                retorno = NumeroPrimo(i);

                if (retorno == true)
                    Console.WriteLine($"El numero {i} es primo");

            }

            Console.ReadKey();
        }

        static bool NumeroPrimo(int numeroIngresado)
        {
            bool primo = false;
            int contador = 0;

            for (int i = 1; i <= numeroIngresado; i++)
            {
                if (numeroIngresado % i == 0)
                    contador++;
            }

            if (contador == 2)
                primo = true;

            return primo;
        }

    }
}
