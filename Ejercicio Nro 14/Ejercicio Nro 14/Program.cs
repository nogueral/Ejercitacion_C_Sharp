using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            Console.WriteLine("Calculo area cuadrado: {0}", CalculoDeArea.CalculoCuadrado(4));
            Console.WriteLine("Calculo area triangulo: {0}", CalculoDeArea.CalculoTriangulo(2, 4));
            Console.WriteLine("Calculo area circulo: {0, 0: #,###.00}", CalculoDeArea.CalculoCirculo(5));
        }
    }
}
