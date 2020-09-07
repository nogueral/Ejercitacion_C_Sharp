using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador_Nro_1
{
    static class Menues
    {
        public static void MenuMostrarProductos()
        {
            byte opcion;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n1. Mostrar todos");
                Console.WriteLine("2. Mostrar segun categoria");
                Console.WriteLine("3. Mostrar segun stock");
                Console.WriteLine("4. Mostrar producto mas vendido");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                switch (opcion)
                {
                    case 1:
                        Inventario.MostrarProductos();
                        break;
                    case 2:
                        Console.Write("Ingrese categoria: ");
                        string auxCategoria = Console.ReadLine();
                        Inventario.Mostrar(auxCategoria);
                        break;
                    case 3:
                        Inventario.MostrarPorStock();
                        break;
                    case 4:
                        Inventario.MostrarProductoMasVendido();
                        break;
                }

            } while (opcion != 5);
        }

        public static void MenuBuscarProductos()
        {
            byte opcion;
            string auxNombre;
            int auxId;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Buscar producto por nombre");
                Console.WriteLine("2. Buscar producto por ID");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese nombre del producto: ");
                        auxNombre = Console.ReadLine();
                        Inventario.BuscarProducto(auxNombre);
                        break;
                    case 2:
                        Console.Write("Ingrese ID del producto: ");
                        int.TryParse(Console.ReadLine(), out auxId);
                        Inventario.BuscarProducto(auxId);
                        break;
                }

            } while (opcion != 3);
        }

        public static void MenuModificarProducto()
        {
            byte opcion;
            string nombre;
            int idProducto;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Busqueda por ID");
                Console.WriteLine("2. Busqueda por nombre");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese ID del producto a modificar: ");
                        int.TryParse(Console.ReadLine(), out idProducto);
                        Inventario.ModificarProducto(idProducto);
                        break;
                    case 2:
                        Console.Write("Ingrese nombre del producto a modificar: ");
                        nombre = Console.ReadLine();
                        Inventario.ModificarProducto(nombre);
                        break;
                }

            } while (opcion != 3);
        }

        public static void MenuEliminarProducto()
        {
            byte opcion;
            int auxID;
            string auxNombre;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Busqueda por ID");
                Console.WriteLine("2. Busqueda por nombre");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese ID del producto que desea eliminar: ");
                        int.TryParse(Console.ReadLine(), out auxID);
                        Inventario.EliminarProducto(auxID);
                        break;
                    case 2:
                        Console.Write("Ingrese nombre del producto que desea eliminar: ");
                        auxNombre = Console.ReadLine();
                        Inventario.EliminarProducto(auxNombre);
                        break;
                }

            } while (opcion != 3);
        }

        public static void MenuFacturacion()
        {
            byte opcion;

            Inventario.CalcularFacturacion();

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Producto que mas facturo");
                Console.WriteLine("2. Mostrar facturacion por producto de menor a mayor");
                Console.WriteLine("3. Mostrar toda la informacion de facturacion");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n******************************");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        Inventario.ProductoQueMasFacturo();
                        break;
                    case 2:
                        Inventario.FacturacionDeMenorAMayor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Facturacion por producto de menor a mayor: \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Inventario.MostrarFacturacion();
                        break;
                    case 3:
                        Inventario.FacturacionTotal();
                        Inventario.ProductoQueMasFacturo();
                        Inventario.FacturacionDeMenorAMayor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Facturacion por producto de menor a mayor: \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Inventario.MostrarFacturacion();
                        break;
                }

            } while (opcion != 4);
        }
    }
}
