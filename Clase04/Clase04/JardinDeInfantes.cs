using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    static class JardinDeInfantes
    {
        static Alumno[] arrayAlumnos;
        static Docente[] arrayDocente;

        static JardinDeInfantes()
        {
            arrayAlumnos = new Alumno[30];
            arrayDocente = new Docente[5];
        }

        /// <summary>
        /// Agrega un objeto de tipo alumno al array
        /// </summary>
        /// <param name="auxAlumno"> alumno a agregar </param>
        /// <returns> devuelve true si el alumno fue agregado </returns>
        public static bool AgregarAlumno(Alumno auxAlumno)
        {
            bool retorno = false;

            for (int i = 0; i < arrayAlumnos.Length; i++)
            {
                if (arrayAlumnos[i] == null)
                {
                    arrayAlumnos[i] = auxAlumno;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
    }
}
