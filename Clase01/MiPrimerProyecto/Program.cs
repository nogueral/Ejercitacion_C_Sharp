using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool dato;
            dato = numero == 0 ? false : true;
            Console.WriteLine(dato);

            // sumar la hora actual con los segundos solo si alguno es mayor a 25

             DateTime horaActual = DateTime.Now;

             int resultado;

             resultado = Program.suma(horaActual.Minute, horaActual.Second);

            Console.WriteLine("El resultado es: {0}", resultado);

             string[] nombres;

             nombres = new string[5];

             Console.WriteLine("Ingrese los nombres: ");

             for(int i=0; i<5; i++)
             {
                 nombres[i] = Console.ReadLine();
             }

             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine(nombres[i]);
             }

             foreach (var item in nombres)
             {
                 Console.WriteLine(item);
             }

            Console.WriteLine("Hora actual: {0}:{1,3:000}:{2,3:000}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            Console.ReadKey();
        }

        static int suma(int sumando1, int sumando2)
        {
            int resultado = 0;
            
            if(sumando1>25 || sumando2>25)
            {
                resultado = sumando1 + sumando2;
            }

            return resultado;
        }
    }
}
