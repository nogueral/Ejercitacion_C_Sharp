using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    static class Cuentas
    {
        static Cliente[] listaClientes;

        static Cuentas()
        {
            listaClientes = new Cliente[2];
        }

        public static bool CargarClientes(Cliente auxCliente)
        {
            bool retorno = false;
            
            for (int i = 0; i < listaClientes.Length; i++)
            {
                if(listaClientes[i] == null)
                {
                    listaClientes[i] = auxCliente;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool GestionarClientes(string auxUsuario, string auxClave)
        {
            byte opcion;
            int auxSaldo;
            bool retorno = false;

            for (int i = 0; i < listaClientes.Length; i++)
            {
                if (listaClientes[i] != null && listaClientes[i].GetUsuario() == auxUsuario && listaClientes[i].GetContrasena() == auxClave)
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
                                Console.WriteLine($"Nombre: {listaClientes[i].GetNombre()}");
                                Console.WriteLine($"Apellido: {listaClientes[i].GetApellido()}");
                                Console.WriteLine($"DNI: {listaClientes[i].GetDni()}");
                                Console.WriteLine($"Cuenta Nro: {listaClientes[i].GetNroCuenta()}");
                                Console.WriteLine($"Saldo: {listaClientes[i].GetSaldo()}");
                                Console.WriteLine("******************************");
                                break;
                            case 2:
                                Console.Write("Por favor, ingrese el monto a acreditar: ");
                                int.TryParse(Console.ReadLine(), out auxSaldo);
                                listaClientes[i].AgregarDinero(auxSaldo);
                                break;
                            case 3:
                                Console.Write("Por favor, ingrese el monto a retirar: ");
                                int.TryParse(Console.ReadLine(), out auxSaldo);
                                if (listaClientes[i].RetirarDinero(auxSaldo))
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

                    retorno = true;
                    break;
                }

            }

            return retorno;
        }
    }
}
