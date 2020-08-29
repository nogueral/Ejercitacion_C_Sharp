using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Galletita galletita1;

            galletita1 = new Galletita();

            Galletita galletita2 = new Galletita();

            galletita1.SetSabor("vainilla");
            galletita2.SetSabor("chocolate");

            Console.WriteLine(galletita1.GetSabor());
            Console.WriteLine(galletita2.GetSabor());
            Console.ReadKey();*/

            /*
            Alumno[] estudiantes = new Alumno[3];
            int auxLegajo;
    
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("Por favor ingrese nombre: ");
                estudiantes[i] = new Alumno();
                estudiantes[i].SetNombre(Console.ReadLine());
            }

            foreach (Alumno item in estudiantes)
            {
                Console.WriteLine(item.GetNombre());
            }

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("Por favor ingrese legajo: ");
                int.TryParse(Console.ReadLine(), out auxLegajo);
                estudiantes[i].SetLegajo(auxLegajo);
            }

            foreach (Alumno item in estudiantes)
            {
                Console.WriteLine(item.GetLegajo());
            }*/

            Persona[] vecinos = new Persona[3];
            int auxEdad;

            for (int i = 0; i < vecinos.Length; i++)
            {
                vecinos[i] = new Persona();
                
                Console.Write("Por favor ingrese nombre: ");
                vecinos[i].nombre = Console.ReadLine();
                
                Console.Write("Por favor ingrese apellido: ");
                vecinos[i].apellido = Console.ReadLine();
                
                Console.Write("Por favor ingrese edad: ");
                int.TryParse(Console.ReadLine(), out auxEdad);
                vecinos[i].edad = auxEdad;
            }

            foreach (Persona item in vecinos)
            {
                Console.WriteLine("Nombre: {0}", item.nombre);
                Console.WriteLine("Apellido: {0}", item.apellido);
                Console.WriteLine("Edad: {0}", item.edad);
            }

            Console.ReadKey();
        }
    }
}
