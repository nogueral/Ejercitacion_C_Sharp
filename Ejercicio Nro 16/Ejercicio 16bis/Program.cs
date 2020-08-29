using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16bis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16bis";

            Alumno[] listaAlumnos = new Alumno[3];


            byte opcion;
            bool valorRetorno;

            

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                listaAlumnos[i] = new Alumno();
            }

            do
            {
                Console.WriteLine("1. Alta Alumno: ");
                Console.WriteLine("2. Baja Alumno: ");
                Console.WriteLine("3. Modificacion Alumno: ");
                Console.WriteLine("4. Cargar notas: ");
                Console.WriteLine("5. Mostrar Alumno: ");
                Console.WriteLine("6. Salir: ");
                Console.WriteLine("Seleccione una opcion: ");
                byte.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        valorRetorno = Alumno.AltaAlumno(listaAlumnos);
                        if (valorRetorno)
                        {
                            Console.WriteLine("Cargado con exito");
                        }
                        else 
                        {
                            Console.WriteLine("No hay mas espacio");
                        }
                    break;
                    case 2:
                        valorRetorno = Alumno.BajaAlumno(listaAlumnos);
                        if (valorRetorno)
                        {
                            Console.WriteLine("Borrado con exito");
                        }
                        else
                        {
                            Console.WriteLine("Error en la operacion");
                        }
                    break;
                    case 3:
                        valorRetorno = Alumno.ModificarAlumno(listaAlumnos);
                        if (valorRetorno)
                        {
                            Console.WriteLine("Modificado con exito");
                        }
                        else
                        {
                            Console.WriteLine("Error en la operacion");
                        }
                    break;
                    case 4:
                        valorRetorno = Alumno.CargarNota(listaAlumnos);
                        if (valorRetorno)
                        {
                            Console.WriteLine("Modificado con exito");
                        }
                        else
                        {
                            Console.WriteLine("Error en la operacion");
                        }
                    break;
                    case 5:
                        valorRetorno = Alumno.MostrarAlumno(listaAlumnos);
                   break;
                }


            } while (opcion != 6);
        }
    }
}
