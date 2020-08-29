using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";
            
            Alumno[] listaAlumnos = new Alumno[3];
            int auxLegajo;
            byte auxNota1;
            byte auxNota2;
            bool validarLegajo=false;

            Random calificacion = new Random();

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                listaAlumnos[i] = new Alumno();

                Console.Write("Ingresar nombre: ");
                listaAlumnos[i].SetNombre(Console.ReadLine());

                Console.Write("Ingresar apellido: ");
                listaAlumnos[i].SetApellido(Console.ReadLine());

                
                do
                {
                    Console.Write("Ingresar legajo: ");
                    validarLegajo = int.TryParse(Console.ReadLine(), out auxLegajo);
                    listaAlumnos[i].SetLegajo(auxLegajo);

                } while (validarLegajo==false);
                

                auxNota1 = (byte)calificacion.Next(1, 10);
                auxNota2 = (byte)calificacion.Next(1, 10);

                listaAlumnos[i].Estudiar(auxNota1, auxNota2);

            }


            foreach  (Alumno auxAlumno in listaAlumnos)
            {
                auxAlumno.Mostrar();
            }

            Console.ReadKey();
        }

    }
}
