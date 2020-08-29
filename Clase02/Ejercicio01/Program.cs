using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente nuevoCliente = new Cliente();
            byte opcion;
            int auxNroCuenta;
            int auxSaldo;
            long auxDni;
            string auxUsuario;
            string auxContrasena;
            Random nuevoRandom = new Random();
            do
            {
                Console.WriteLine("***********Banco***********");
                Console.WriteLine("1. Cargar datos cliente");
                Console.WriteLine("2. Operar");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese la opcion deseada: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine("***************************");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese usuario: ");
                        auxUsuario = Console.ReadLine();
                        Cliente.ValidarUsers(ref auxUsuario);
                        nuevoCliente.SetUsuario(auxUsuario);
                        Console.Write("Ingrese contraseña: ");
                        auxContrasena = Console.ReadLine();
                        Cliente.ValidarUsers(ref auxContrasena);
                        nuevoCliente.SetClave(auxContrasena);
                        Console.Write("Ingrese nombre: ");
                        nuevoCliente.SetNombre(Console.ReadLine());
                        Console.Write("Ingrese apellido: ");
                        nuevoCliente.SetApellido(Console.ReadLine());
                        Console.Write("Ingrese DNI: ");
                        long.TryParse(Console.ReadLine(), out auxDni);
                        nuevoCliente.SetDni(auxDni);
                        auxNroCuenta = nuevoRandom.Next(3000, 4000);
                        nuevoCliente.SetNroCuenta(auxNroCuenta);
                        auxSaldo = nuevoRandom.Next(8000, 9000);
                        nuevoCliente.SetSaldo(auxSaldo);
                        break;
                    case 2:

                        Console.Write("Ingrese usuario: ");
                        auxUsuario = Console.ReadLine();
                        Cliente.ValidarUsers(ref auxUsuario);
                        Console.Write("Ingrese contraseña: ");
                        auxContrasena = Console.ReadLine();
                        Cliente.ValidarUsers(ref auxContrasena);

                        if (nuevoCliente.GetUsuario()==auxUsuario && nuevoCliente.GetContrasena()==auxContrasena)
                        {
                            do
                            {
                                Console.WriteLine("***********Banco***********");
                                Console.WriteLine("1. Mostrar datos");
                                Console.WriteLine("2. Agregar dinero");
                                Console.WriteLine("3. Retirar dinero");
                                Console.WriteLine("4. Salir");
                                Console.Write("Ingrese la opcion deseada: ");
                                byte.TryParse(Console.ReadLine(), out opcion);
                                Console.WriteLine("***************************");

                                switch (opcion)
                                {
                                    case 1:
                                        Console.WriteLine("*****Informacion Bancaria*****");
                                        Console.WriteLine($"Nombre: {nuevoCliente.GetNombre()}");
                                        Console.WriteLine($"Apellido: {nuevoCliente.GetApellido()}");
                                        Console.WriteLine($"DNI: {nuevoCliente.GetDni()}");
                                        Console.WriteLine($"Cuenta Nro: {nuevoCliente.GetNroCuenta()}");
                                        Console.WriteLine($"Saldo: {nuevoCliente.GetSaldo()}");
                                        Console.WriteLine("******************************");
                                        break;
                                    case 2:
                                        Console.Write("Por favor, ingrese el monto a acreditar: ");
                                        int.TryParse(Console.ReadLine(), out auxSaldo);
                                        nuevoCliente.AgregarDinero(auxSaldo);
                                        break;
                                    case 3:
                                        Console.Write("Por favor, ingrese el monto a retirar: ");
                                        int.TryParse(Console.ReadLine(), out auxSaldo);
                                        if (nuevoCliente.RetirarDinero(auxSaldo))
                                        {
                                            Console.WriteLine("Operacion exitosa");

                                        }
                                        else
                                        {
                                            Console.WriteLine("La cuenta no dispone de suficiente dinero");
                                        }
                                        break;
                                }


                            } while (opcion != 4);

                        }
                        else
                        {
                            Console.WriteLine("Usuario o contraseña incorrecta");
                        }


                        break;
                }


            } while (opcion!=3);


        }
    }
}
