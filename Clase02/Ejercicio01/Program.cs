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
            byte opcion;
            string auxUsuario;
            string auxContrasena;
            string nombre;
            string apellido;
            long dni;
            string usuario;
            string clave;
            int nroCuenta;
            double saldo;

            do
            {
                Console.WriteLine("***********Banco***********");
                Console.WriteLine("1. Inicializar datos cliente");
                Console.WriteLine("2. Operar");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese la opcion deseada: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine("***************************");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese apellido: ");
                        apellido = Console.ReadLine();
                        Console.Write("Ingrese usuario: ");
                        usuario = Console.ReadLine();
                        ValidarUsers(ref usuario);
                        Console.Write("Ingrese contraseña: ");
                        clave = Console.ReadLine();
                        ValidarUsers(ref clave);
                        Console.Write("Ingrese DNI: ");
                        long.TryParse(Console.ReadLine(), out dni);
                        Console.Write("Ingrese Nro Cuenta: ");
                        int.TryParse(Console.ReadLine(), out nroCuenta);
                        Console.Write("Ingrese Saldo: ");
                        double.TryParse(Console.ReadLine(), out saldo);
                        if(Cuentas.CargarClientes(new Cliente(nombre, apellido, dni, usuario, clave, nroCuenta, saldo)))
                        {
                            Console.WriteLine("Datos cargados correctamente");
                        } else
                        {
                            Console.WriteLine("Error en la carga, verifique espacio disponible");
                        }
                        break;
                    case 2:
                        Console.Write("Ingrese usuario: ");
                        auxUsuario = Console.ReadLine();
                        ValidarUsers(ref auxUsuario);
                        Console.Write("Ingrese contraseña: ");
                        auxContrasena = Console.ReadLine();
                        ValidarUsers(ref auxContrasena);
                        if(!Cuentas.GestionarClientes(auxUsuario, auxContrasena))
                        {
                            Console.WriteLine("Usuario o clave incorrecta");
                        }
                        break;
                }


            } while (opcion!=3);


        }

        public static void ValidarUsers(ref string dato)
        {

            while (string.IsNullOrEmpty(dato))
            {
                Console.Write("El dato ingresado no puede ser vacio o nulo, reingrese: ");
                dato = Console.ReadLine();
            }
        }
    }
}
