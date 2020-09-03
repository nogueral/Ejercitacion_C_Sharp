using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";
            char rta = 'n';
            double valor1;
            double valor2;
            char operacion;
            double resultado;

            do
            {
                Console.Write("Ingrese valor 1: ");
                double.TryParse(Console.ReadLine(), out valor1);
                Console.WriteLine();

                Console.Write("Ingrese valor 2: ");
                double.TryParse(Console.ReadLine(), out valor2);
                Console.WriteLine();

                Console.Write("Ingrese operacion (+, -, *, /): ");
                char.TryParse(Console.ReadLine(), out operacion);
                Console.WriteLine();

                resultado = Calculadora.Calcular(valor1, valor2, operacion);

                Console.Write("El resultado de la operacion es: {0}", resultado);
                Console.WriteLine();

                Console.Write("Desea continuar (s/n)?: ");
                char.TryParse(Console.ReadLine(), out rta);
                Console.WriteLine();
            } while (rta == 's');

        }
    }
}
