using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;
            char respuesta;
            bool ingreso;

            Console.Title = "Ejercicio Nro 12";

            do
            {
                Console.Write("Ingrese numero: ");
                ingreso = int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (!ingreso)
                {
                    Console.Write("Ingreso un valor incorrecto, reingrese: ");
                    ingreso = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                acumulador += numeroIngresado;
                Console.Write("Desea continuar (s/n): ");
                char.TryParse(Console.ReadLine(), out respuesta);

            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine($"La sumatoria total es: {acumulador}");

            Console.ReadKey();
        }
    }
}
