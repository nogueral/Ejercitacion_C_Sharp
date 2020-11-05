using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 54";
            string auxStackTrace = String.Empty;
            string path = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("yyyyMMdd-HHmm");

            try
            {
                OtraClase auxClase = new OtraClase();

                auxClase.MetodoInstancia();

            }
            catch (Exception e)
            {
                try
                {
                    while (e != null)
                    {
                        //Console.WriteLine(e.Message);

                        auxStackTrace += e.StackTrace.ToString() + "\n";

                        e = e.InnerException;

                    }

                    if (ArchivoTexto.Guardar(path, auxStackTrace))
                    {
                        Console.WriteLine("Archivo guardado correctamente");
                    }


                }
                catch (Exception error)
                {

                    Console.WriteLine(error.Message);
                }



            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Lista de stacktrace traida desde archivo: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ArchivoTexto.Leer(path));
                Console.ResetColor();
                Console.ReadKey();
            }


        }
    }
}
