using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_integrador_Nro_1
{
    static class Inventario
    {
        static Producto[] listaProductos;
        static Facturacion[] listaFacturacion;

        static Inventario()
        {
            listaProductos = new Producto[12];
            listaFacturacion = new Facturacion[12];
        }

        public static void HardcodeoProductos()
        {
            string[] nombre = new string[10] { "Ladrillo", "Flexible caño", "Destornillador", "Canillas", "Bombillas", "Bolsa arena", "Caños agua", "Martillo", "Pinza", "Cable (por metro)" };
            int[] idProducto = new int[10] { 12, 10, 15, 11, 4, 90, 1, 31, 9, 7 };
            string[] categoria = new string[10] { "Construccion", "Plomeria", "Herramientas", "Plomeria", "Electricidad", "Construccion", "Plomeria", "Herramientas", "Herramientas", "Electricidad" };
            double[] precio = new double[10] { 80, 100, 95, 45, 20, 60, 100, 120, 135, 50 };
            string[] stockActual = new string[10] { "120", "5", "124", "15", "300", "45", "Sin stock", "150", "80", "98" };
            int[] cantidadVendidos = new int[10] { 50, 495, 13, 1200, 100, 1500, 500, 95, 25, 30 };

            for (int i = 0; i < 10; i++)
            {
                listaProductos[i] = new Producto(nombre[i], idProducto[i], categoria[i], precio[i], stockActual[i], cantidadVendidos[i]);
            }
        }

        public static void MostrarProductos()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Producto item in listaProductos)
            {
                if (item != null)
                {
                    MostrarUnProducto(item);
                }

            }
        }

        public static void MostrarFacturacion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nombre               - Id    - Facturacion\n");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Facturacion item in listaFacturacion)
            {
                if (item != null)
                {
                    MostrarUnProducto(item);
                }
            }
        }

        static void MostrarUnProducto(Producto item)
        {
            Console.WriteLine("{0,-20} - {1, -5} - {2,-20} - ${3,-10:#,###.00} - {4,-10} - {5}\n", item.GetNombre(),
            item.GetIdProducto(), item.GetCategoria(), item.GetPrecio(), item.GetStock(),
            item.GetCantVendidos());
        }

        static void MostrarUnProducto(Facturacion item)
        {
            Console.WriteLine("{0, -20} - {1, -5} - ${2, -10:#,###.00}\n", item.GetNombre(),
            item.GetIdProducto(), item.GetFacturacion());
        }

        public static void Mostrar(string auxCategoria)
        {
            bool encontro = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if(listaProductos[i] != null && listaProductos[i].GetCategoria() == auxCategoria)
                {
                    MostrarUnProducto(listaProductos[i]);
                    encontro = true;
                }
            }

            if (encontro == false)
            {
                Console.WriteLine("Categoria inexistente");
            }
        }

        public static void MostrarPorStock()
        {
            byte opcion;

            do
            {
                Console.WriteLine("1. Sin stock");
                Console.WriteLine("2. Con stock, pero menor a 100 unidades");
                Console.WriteLine("3. Con stock, pero mayor a 100 unidades");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        for (int i = 0; i < listaProductos.Length; i++)
                        {
                            if(listaProductos[i]!=null && listaProductos[i].GetStock()=="Sin stock")
                            {
                                MostrarUnProducto(listaProductos[i]);
                            }
                        }
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        for (int i = 0; i < listaProductos.Length; i++)
                        {
                            if (listaProductos[i] != null && listaProductos[i].GetStock() != "Sin stock" && Convert.ToInt32(listaProductos[i].GetStock()) < 100)
                            {
                                MostrarUnProducto(listaProductos[i]);
                            }
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        for (int i = 0; i < listaProductos.Length; i++)
                        {
                            if (listaProductos[i] != null && listaProductos[i].GetStock() != "Sin stock" && Convert.ToInt32(listaProductos[i].GetStock()) > 100)
                            {
                                MostrarUnProducto(listaProductos[i]);
                            }
                        }
                        break;
                }

            } while (opcion != 4);
        }

        public static void MostrarProductoMasVendido()
        {
            int maxVendidos = -1;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if(listaProductos[i]!=null && listaProductos[i].GetCantVendidos() > maxVendidos)
                {
                    maxVendidos = listaProductos[i].GetCantVendidos();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Producto item in listaProductos)
            {
                if(item != null && item.GetCantVendidos() == maxVendidos)
                {
                    MostrarUnProducto(item);
                }
            }

        }

        public static bool BuscarProducto(string auxNombre)
        {
            bool retorno = false;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if (listaProductos[i] != null && listaProductos[i].GetNombre() == auxNombre)
                {
                    MostrarUnProducto(listaProductos[i]);
                    retorno = true;
                    break;
                }
            }

            if (retorno == false)
            {
                Console.WriteLine($"El producto buscado por nombre {auxNombre} no existe en sistema");
            }

            return retorno;
        }

        public static bool BuscarProducto(int auxId)
        {
            bool retorno = false;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNombre               - Id    - Categoria            - Precio     - Stock      - Cantidad vendidos\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if (listaProductos[i] != null && listaProductos[i].GetIdProducto() == auxId)
                {
                    MostrarUnProducto(listaProductos[i]);
                    retorno = true;
                    break;
                }
            }

            if (retorno == false)
            {
                Console.WriteLine($"El producto buscado por ID {auxId} no existe en sistema");
            }

            return retorno;
        }

        public static void AgregarProducto()
        {
            string nombre;
            int idProducto;
            string categoria;
            double precio;
            string stockActual;
            int cantidadVendidos;

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese ID: ");
            int.TryParse(Console.ReadLine(), out idProducto);
            Console.Write("Ingrese categoria: ");
            categoria = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            double.TryParse(Console.ReadLine(), out precio);
            Console.Write("Ingrese stock: ");
            stockActual = Console.ReadLine();
            Console.Write("Ingrese cantidad vendidos: ");
            int.TryParse(Console.ReadLine(), out cantidadVendidos);

            Producto auxProducto = new Producto(nombre, idProducto, categoria, precio, stockActual, cantidadVendidos);

            if (listaProductos + auxProducto)
            {
                Console.WriteLine("Producto correctamente cargado");

            } else
            {
                if(listaProductos == auxProducto)
                {
                    Console.WriteLine("No se puede cargar el producto porque ya existe en sistema");

                }
                else
                {
                    Console.WriteLine("No hay mas espacio");
                }
            }


        }

        public static void ModificarProducto(string nombre)
        {
            int idProducto;
            double precio;
            int cantidadVendidos;
            byte opcion;
            bool modifica = false;
            bool encontro = false;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if(listaProductos[i] != null && listaProductos[i].GetNombre() == nombre)
                {
                    do
                    {
                        Console.WriteLine("1. Nombre");
                        Console.WriteLine("2. ID");
                        Console.WriteLine("3. Categoria");
                        Console.WriteLine("4. Precio");
                        Console.WriteLine("5. Stock");
                        Console.WriteLine("6. Cantidad vendidos");
                        Console.WriteLine("7. Salir");
                        Console.Write("Seleccione una opcion: ");
                        byte.TryParse(Console.ReadLine(), out opcion);

                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese nombre: ");
                                listaProductos[i].SetNombre(Console.ReadLine());
                                modifica = true;
                                break;
                            case 2:
                                Console.Write("Ingrese ID: ");
                                int.TryParse(Console.ReadLine(), out idProducto);
                                listaProductos[i].SetId(idProducto);
                                modifica = true;
                                break;
                            case 3:
                                Console.Write("Ingrese categoria: ");
                                listaProductos[i].SetCategoria(Console.ReadLine());
                                modifica = true;
                                break;
                            case 4:
                                Console.Write("Ingrese precio: ");
                                double.TryParse(Console.ReadLine(), out precio);
                                listaProductos[i].SetPrecio(precio);
                                modifica = true;
                                break;
                            case 5:
                                Console.Write("Ingrese stock: ");
                                listaProductos[i].SetStock(Console.ReadLine());
                                modifica = true;
                                break;
                            case 6:
                                Console.Write("Ingrese cantidad vendidos: ");
                                int.TryParse(Console.ReadLine(), out cantidadVendidos);
                                listaProductos[i].SetCantidadVendidos(cantidadVendidos);
                                modifica = true;
                                break;
                        }

                    } while (opcion != 7);


                    if (modifica == true)
                    {
                        Console.WriteLine("Modificado con exito");

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada, no se modificaron datos");
                    }

                    encontro = true;
                    break;

                }
            }

            if (encontro == false)
            {
                Console.WriteLine($"El producto buscado por nombre {nombre} no existe en sistema");
            }
            
        }

        public static void ModificarProducto(int auxID)
        {
            int idProducto;
            double precio;
            int cantidadVendidos;
            byte opcion;
            bool modifica = false;
            bool encontro = false;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if (listaProductos[i] != null && listaProductos[i].GetIdProducto() == auxID)
                {
                    do
                    {
                        Console.WriteLine("1. Nombre");
                        Console.WriteLine("2. ID");
                        Console.WriteLine("3. Categoria");
                        Console.WriteLine("4. Precio");
                        Console.WriteLine("5. Stock");
                        Console.WriteLine("6. Cantidad vendidos");
                        Console.WriteLine("7. Salir");
                        Console.Write("Seleccione una opcion: ");
                        byte.TryParse(Console.ReadLine(), out opcion);

                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese nombre: ");
                                listaProductos[i].SetNombre(Console.ReadLine());
                                modifica = true;
                                break;
                            case 2:
                                Console.Write("Ingrese ID: ");
                                int.TryParse(Console.ReadLine(), out idProducto);
                                listaProductos[i].SetId(idProducto);
                                modifica = true;
                                break;
                            case 3:
                                Console.Write("Ingrese categoria: ");
                                listaProductos[i].SetCategoria(Console.ReadLine());
                                modifica = true;
                                break;
                            case 4:
                                Console.Write("Ingrese precio: ");
                                double.TryParse(Console.ReadLine(), out precio);
                                listaProductos[i].SetPrecio(precio);
                                modifica = true;
                                break;
                            case 5:
                                Console.Write("Ingrese stock: ");
                                listaProductos[i].SetStock(Console.ReadLine());
                                modifica = true;
                                break;
                            case 6:
                                Console.Write("Ingrese cantidad vendidos: ");
                                int.TryParse(Console.ReadLine(), out cantidadVendidos);
                                listaProductos[i].SetCantidadVendidos(cantidadVendidos);
                                modifica = true;
                                break;
                        }

                    } while (opcion != 7);


                    if (modifica == true)
                    {
                        Console.WriteLine("Modificado con exito");

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada, no se modificaron datos");
                    }

                    encontro = true;
                    break;

                }
            }

            if (encontro == false)
            {
                Console.WriteLine($"El producto buscado por ID {auxID} no existe en sistema");
            }

        }

        public static void EliminarProducto(int auxID)
        {
            char respuesta;
            bool encontro = false;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if(listaProductos[i] != null && listaProductos[i].GetIdProducto() == auxID)
                {
                    encontro = true;

                    do
                    {
                        Console.WriteLine($"Esta por eliminar el producto {listaProductos[i].GetNombre()}");
                        Console.Write("Desea continuar (s/n): ");
                        char.TryParse(Console.ReadLine(), out respuesta);
                    } while (respuesta != 's' && respuesta != 'n');

                    if (respuesta == 's')
                    {
                        if(listaProductos - listaProductos[i])
                        {
                            Console.WriteLine("Producto eliminado con exito");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada");
                    }

                }
            }

            if (encontro == false)
            {
                Console.WriteLine("ID inexistente");
            }
        }

        public static void EliminarProducto(string auxNombre)
        {
            char respuesta;
            bool encontro = false;

            for (int i = 0; i < listaProductos.Length; i++)
            {
                if (listaProductos[i] != null && listaProductos[i].GetNombre() == auxNombre)
                {
                    encontro = true;

                    do
                    {
                        Console.WriteLine($"Esta por eliminar el producto {listaProductos[i].GetNombre()}");
                        Console.Write("Desea continuar (s/n): ");
                        char.TryParse(Console.ReadLine(), out respuesta);
                    } while (respuesta != 's' && respuesta != 'n');

                    if (respuesta == 's')
                    {
                        if (listaProductos - listaProductos[i])
                        {
                            Console.WriteLine("Producto eliminado con exito");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada");
                    }

                }
            }

            if (encontro == false)
            {
                Console.WriteLine("Nombre inexistente");
            }
        }

        public static void CalcularFacturacion()
        {
            
            for (int i = 0; i < listaProductos.Length; i++)
            {
                if (listaProductos[i] != null)
                {
                    listaFacturacion[i] = (Facturacion) listaProductos[i];
                }
            }
        }

        public static void ProductoQueMasFacturo()
        {
            double auxFacturacion = -1;
            
            for (int i = 0; i < listaFacturacion.Length; i++)
            {
                if (listaFacturacion[i] != null)
                {
                    if(auxFacturacion < listaFacturacion[i].GetFacturacion())
                    {
                        auxFacturacion = listaFacturacion[i].GetFacturacion();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Producto con mayor facturacion: \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nombre               - Id    - Facturacion\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < listaFacturacion.Length; i++)
            {
                if (listaFacturacion[i] != null && auxFacturacion == listaFacturacion[i].GetFacturacion())
                {
                    MostrarUnProducto(listaFacturacion[i]);
                }
            }
        }

        public static void FacturacionDeMenorAMayor()
        {
            Facturacion auxFacturacion = new Facturacion();

            for (int i = 0; i < listaFacturacion.Length-1; i++)
            {
                for (int j = i+1; j < listaFacturacion.Length; j++)
                {
                    if(listaFacturacion[i] != null && listaFacturacion[j] != null)
                    {
                        if(listaFacturacion[i].GetFacturacion() > listaFacturacion[j].GetFacturacion())
                        {
                            auxFacturacion = listaFacturacion[i];
                            listaFacturacion[i] = listaFacturacion[j];
                            listaFacturacion[j] = auxFacturacion;
                        }
                    }
                }
            }
        }

        public static void FacturacionTotal()
        {
            double acumulador = 0;
            
            for (int i = 0; i < listaFacturacion.Length; i++)
            {
                if (listaFacturacion[i] != null)
                {
                    acumulador += listaFacturacion[i].GetFacturacion();
                }
            }
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La facturacion total fue de: ${0:#,###.00}\n", acumulador);
        }
    }
}
