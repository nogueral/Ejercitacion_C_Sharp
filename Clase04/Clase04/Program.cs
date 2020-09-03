using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {

          /*  Alumno[] arrayEstudiantes = new Alumno[5];
            arrayEstudiantes[0] = new Alumno("pepito", "juancito", 1234);
            arrayEstudiantes[1] = new Alumno("pepito", "juancito", 2222, 1234);
            arrayEstudiantes[2] = new Alumno("pepito", "juancito", 3333, 5678, "sala rosa");
            arrayEstudiantes[3] = new Alumno("pepito", "juancito", 4444);
            arrayEstudiantes[4] = new Alumno("pepito", "juancito", 5555);*/

            Alumno miEstudiante = new Alumno("Leandro", "Noguera", 12345, 2222, "sala verde");
            Docente miDocente = new Docente(23456, "Pepe", "Pepe", 3333);

            Console.WriteLine("Creacion de objeto alumno\n");
            Console.WriteLine(miEstudiante.GetNombre());
            Console.WriteLine(miEstudiante.GetApellido());
            Console.WriteLine(miEstudiante.GetDni());
            Console.WriteLine(miEstudiante.GetLegajo());
            Console.WriteLine(miEstudiante.GetCurso());

            Console.WriteLine("\nCreacion de objeto docente\n");
            Console.WriteLine(miDocente.GetNombre());
            Console.WriteLine(miDocente.GetApellido());
            Console.WriteLine(miDocente.GetDni());
            Console.WriteLine(miDocente.GetLegajo());

            Console.WriteLine("\n----------------------------------------\n");

            miEstudiante = miDocente;

            Console.WriteLine("Conversion implicita miEstudiante = miDocente\n");
            Console.WriteLine(miEstudiante.GetNombre());
            Console.WriteLine(miEstudiante.GetApellido());
            Console.WriteLine(miEstudiante.GetDni());
            Console.WriteLine(miEstudiante.GetLegajo());

            miDocente = (Docente) miEstudiante;

            Console.WriteLine("\nConversion explicita miEstudiante = miDocente\n");
            Console.WriteLine(miDocente.GetNombre());
            Console.WriteLine(miDocente.GetApellido());
            Console.WriteLine(miDocente.GetDni());
            Console.WriteLine(miDocente.GetLegajo());

            /* if (arrayEstudiantes == miEstudiante)
             {
                 Console.WriteLine("Alumno encontrado");

             } 

             if (arrayEstudiantes - miEstudiante)
             {
                 Console.WriteLine("Se elimino el alumno");
             }

             if (arrayEstudiantes != miEstudiante)
             {
                 Console.WriteLine("El alumno no esta cargado en el array");

             }

             if (arrayEstudiantes + miEstudiante)
             {
                 Console.WriteLine("Alumno agregado");
             }*/

            /*JardinDeInfantes.AgregarAlumno(miEstudiante);
            JardinDeInfantes.AgregarAlumno(new Alumno("Juan", "Perez", 5678));*/

        }
    }
}
