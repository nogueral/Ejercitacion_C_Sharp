using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador_Nro_1
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
                Console.WriteLine("1. Mostrar productos");
                Console.WriteLine("2. Buscar producto");
                Console.WriteLine("3. Agregar nuevo producto");
                Console.WriteLine("4. Modificar producto");
                Console.WriteLine("5. Eliminar producto");
                Console.WriteLine("6. Facturacion");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("******************************\n");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        Menues.MenuMostrarProductos();
                        break;
                    case 2:
                        Menues.MenuBuscarProductos();
                        break;
                    case 3:
                        Inventario.AgregarProducto();
                        break;
                    case 4:
                        Menues.MenuModificarProducto();
                        break;
                    case 5:
                        Menues.MenuEliminarProducto();
                        break;
                    case 6:
                        Menues.MenuFacturacion();
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
