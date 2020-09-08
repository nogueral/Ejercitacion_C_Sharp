using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador prueba1 = new Sumador();
            Sumador prueba2 = new Sumador(2);
            int cantidadSumas;
            long contador;

            Console.WriteLine("Suma: {0}", prueba1.Sumar(10, 10));
            Console.WriteLine("Suma: {0}", prueba1.Sumar("Hola", "mundo"));

            cantidadSumas = (int) prueba1;

            Console.WriteLine("Cantidad sumas: {0}",cantidadSumas);

            contador = prueba1 + prueba2;

            Console.WriteLine("Contador: {0}", contador);

            if (prueba1 | prueba2)
            {
                Console.WriteLine("Poseen la misma cantidad de sumas");

            } else
            {
                Console.WriteLine("Los valores son diferentes");
            }
        }
    }
}
