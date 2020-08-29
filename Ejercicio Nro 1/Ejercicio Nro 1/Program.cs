using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar 5 nros x consola. Guardar en variable escalar.
             Mostrar maximo, minimo, promedio*/

            Console.Title = "Ejercicio Nro 01";
            /*Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;*/

            int numeroIngresado;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            float promedio;
            bool flagMax = true;
            bool flagMin = true;

            Console.WriteLine("Ingrese 5 numeros: ");

            for (int i = 0; i < 5; i++)
            {
                numeroIngresado = int.Parse(Console.ReadLine());

                if (flagMax == true || numeroIngresado > maximo)
                {
                    maximo = numeroIngresado;
                    flagMax = false;
                }

                if (flagMin == true || numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;
                    flagMin = false;
                }

                acumulador += numeroIngresado;
            }

            promedio = (float)acumulador / 5;

            Console.WriteLine($"El numero maximo es: {maximo}");
            Console.WriteLine($"El numero minimo es: {minimo}");
            Console.WriteLine("El Promedio es: {0:#,###.00}", promedio);

            Console.ReadKey();

        }
    }
}
