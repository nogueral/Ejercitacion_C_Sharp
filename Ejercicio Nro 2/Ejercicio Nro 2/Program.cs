using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_2
{
    class Program
    {
        /*Ingresar un nro y mostrar el cuadrado y el cubo del mismo. Validar que sea mayor que 0
         caso contrario mostrar el mensaje "ERROR ¡Reingresar numero! Utilizar el metodo pow
        de la clase math para realizar la operacion*/
        static void Main(string[] args)
        {
            double numero;

            Console.Title = "Ejercicio Nro 2";
            Console.WriteLine("Por favor, ingrese un numero: ");

            numero = double.Parse(Console.ReadLine());

            while (numero < 0)
            {
                Console.WriteLine("ERROR¡Reingrese numero!");
                numero = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado es: {0}", Math.Pow(numero, 2));
            Console.WriteLine("El cubo es: {0}", Math.Pow(numero, 3));
            Console.ReadKey();
        }
    }
}
