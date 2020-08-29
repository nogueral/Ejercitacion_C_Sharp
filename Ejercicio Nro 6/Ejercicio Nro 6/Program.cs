using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_6
{

    /*
    Escribir un programa que determine si un año es bisiesto.
    Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
    también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
    Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
    Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
     */

    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.Write("Ingrese año inicio: ");
            anioInicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año fin: ");
            anioFin = int.Parse(Console.ReadLine());

            while (anioInicio <= anioFin)
            {
                if (anioInicio % 4 == 0)
                    Console.WriteLine($"El año {anioInicio} es bisiesto");

                anioInicio++;
            }

            Console.ReadKey();
        }
    }
}
