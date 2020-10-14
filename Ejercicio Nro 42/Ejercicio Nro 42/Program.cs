using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 42";
            string auxStackTrace = String.Empty;

            try
            {
                OtraClase auxClase = new OtraClase();

                auxClase.MetodoInstancia();

            }
            catch (Exception e)
            {
                Console.WriteLine("Lista mensajes: ");

                while (e != null)
                {
                    Console.WriteLine(e.Message);

                    auxStackTrace += e.StackTrace.ToString() + "\n";

                    e = e.InnerException;

                }

                Console.WriteLine("Lista de stacktrace: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(auxStackTrace);
                Console.ResetColor();

            }

            



        }
    }
}
