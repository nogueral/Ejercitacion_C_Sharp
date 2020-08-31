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
            Animales[] listaAnimales = new Animales[3];
            int auxEdad;
            float auxPeso;
            byte opcion;
            string auxNombre;

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                listaAnimales[i] = new Animales();

                Console.Write("Ingrese tipo: ");
                listaAnimales[i].SetTipo(Console.ReadLine());
                Console.Write("Ingrese edad: ");
                int.TryParse(Console.ReadLine(), out auxEdad);
                listaAnimales[i].SetEdad(auxEdad);
                Console.Write("Ingrese peso: ");
                float.TryParse(Console.ReadLine(), out auxPeso);
                listaAnimales[i].SetPeso(auxPeso);
                Console.Write("Ingrese nombre: ");
                listaAnimales[i].SetNombre(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("********Veterinaria********");
                Console.WriteLine("1. Mostrar informacion mascotas");
                Console.WriteLine("2. Buscar mascota");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese la opcion deseada: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine("***************************");

                switch (opcion)
                {
                    case 1:
                        CacularPromedio(listaAnimales);
                        PerroMasViejo(listaAnimales);
                        FiltrarMascotas(listaAnimales);
                        break;
                    case 2:
                        Console.Write("Por favor ingrese nombre de la mascota: ");
                        auxNombre = Console.ReadLine();
                        for (int i = 0; i < listaAnimales.Length; i++)
                        {
                            if(listaAnimales[i].GetNombre() == auxNombre)
                            {
                                Console.WriteLine($"Nombre: {listaAnimales[i].GetNombre()}");
                                Console.WriteLine($"Tipo: {listaAnimales[i].GetTipo()}");
                                Console.WriteLine($"Edad: {listaAnimales[i].GetEdad()}");
                                Console.WriteLine($"Peso: {listaAnimales[i].GetPeso()}");
                            }
                        }
                        break;
                }

            } while (opcion != 3);
        }

        static void CacularPromedio(Animales[] listaAnimales)
        {
            float promedio;
            float acumuladorPesos = 0;

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                acumuladorPesos += listaAnimales[i].GetPeso();
            }

            promedio = acumuladorPesos / listaAnimales.Length;

            Console.WriteLine($"El promedio de pesos es: {promedio}");
        }

        static void PerroMasViejo(Animales[] listaAnimales)
        {
            bool flag = true;
            int mayorEdad=0;
            string nombreMayor = "";

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if(flag==true || mayorEdad < listaAnimales[i].GetEdad())
                {
                    flag = false;
                    mayorEdad = listaAnimales[i].GetEdad();
                    nombreMayor = listaAnimales[i].GetNombre();
                }
            }

            Console.WriteLine($"El nombre del perro mas viejo es: {nombreMayor}");
        }

        static void FiltrarMascotas(Animales[] listaAnimales)
        {
            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if(listaAnimales[i].GetPeso()<10 && listaAnimales[i].GetEdad() > 10)
                {
                    Console.WriteLine($"Nombre: {listaAnimales[i].GetNombre()}");
                    Console.WriteLine($"Nombre: {listaAnimales[i].GetTipo()}");
                }
            }
        }
    }
}
