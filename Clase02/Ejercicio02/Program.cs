using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxEdad;
            double auxPeso;
            bool validarEntrada;
            byte opcion;
            string auxNombre;
            string auxTipo;

            do
            {
                Console.WriteLine("********Veterinaria********");
                Console.WriteLine("1. Cargar mascota");
                Console.WriteLine("2. Mostrar informacion mascotas");
                Console.WriteLine("3. Buscar mascota");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese la opcion deseada: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine("***************************");

                switch (opcion)
                {
                    case 1:
                       do
                        {
                            Console.Write("Ingrese tipo (perro o gato): ");
                            auxTipo = Console.ReadLine();
                        } while (!Validaciones.ValidarTipo(auxTipo));

                        do
                        {
                            Console.Write("Ingrese peso (entre 1 y 100kg): ");
                            validarEntrada = double.TryParse(Console.ReadLine(), out auxPeso);
                        } while (!Validaciones.ValidarPeso(auxPeso) && validarEntrada);

                        do
                        {
                            Console.Write("Ingrese edad (entre 1 y 25 años): ");
                            validarEntrada = int.TryParse(Console.ReadLine(), out auxEdad);
                        } while (!Validaciones.ValidarEdad(auxEdad) && validarEntrada);
                       
                        Console.Write("Ingrese nombre: ");
                        auxNombre = Console.ReadLine();

                        if(Veterinaria.CargarMascota(new Animales(auxTipo, auxNombre, auxPeso, auxEdad)))
                        {
                            Console.WriteLine("Carga correcta");
                        }
                        else
                        {
                            Console.WriteLine("Error de carga, verificar espacio disponible");
                        }
                        break;
                    case 2:
                        Veterinaria.CacularPromedio();
                        Veterinaria.PerroMasViejo();
                        Veterinaria.FiltrarMascotas();
                        break;
                    case 3:
                        Console.Write("Por favor ingrese nombre de la mascota: ");
                        Veterinaria.MostrarMascota(Console.ReadLine());
                        break;
                }

            } while (opcion != 4);
        }


    }
}
