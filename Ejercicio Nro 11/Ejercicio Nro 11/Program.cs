using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_Nro_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 11";
            int numeroIngresado;
            bool valid1;
            bool valid2;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            bool flagMax = true;
            bool flagMin = true;
            float promedio;

            Console.WriteLine("Se deben ingresar 10 numeros enteros: ");
            Console.WriteLine("(Comprendidos entre -100 y 100)");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese numero: ");
                valid1 = int.TryParse(Console.ReadLine(), out numeroIngresado);
                valid2 = Validacion.Validar(numeroIngresado, -100, 100);

                while (valid1==false || valid2==false)
                {
                    Console.Write("Error de parametro, reingrese: ");
                    valid1 = int.TryParse(Console.ReadLine(), out numeroIngresado);
                    valid2 = Validacion.Validar(numeroIngresado, -100, 100);
                }

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

            promedio = (float)acumulador / 10;

            Console.WriteLine($"El numero maximo es: {maximo}");
            Console.WriteLine($"El numero minimo es: {minimo}");
            Console.WriteLine("El Promedio es: {0:#,###.00}", promedio);

            Console.ReadKey();
        }
    }
}
