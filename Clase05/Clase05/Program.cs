using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            char respuesta = 'n';

            Inventario.HardcodeoProductos();

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. ");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("******************************\n");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        Inventario.HardcodeoProductos();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                      
                        break;
                    case 4:
                       
                        break;
                    case 5:
                       
                        break;
                    case 6:
                       
                        break;
                    case 7:
                        Console.Write("Desea cerrar el programa? (s/n): ");
                        char.TryParse(Console.ReadLine(), out respuesta);
                        break;

                }

            } while (respuesta != 's');

        }
    }
}
