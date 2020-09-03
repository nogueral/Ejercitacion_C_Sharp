using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Docente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int legajo;

        public Docente(int dni, string nombre, string apellido):this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;

        }

        private Docente()
        {
            this.dni = -1;
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.legajo = -1;
        }

        public Docente(int dni, string nombre, string apellido, int legajo):this(dni,nombre,apellido)
        {
            this.legajo = legajo;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public int GetLegajo()
        {
            return this.legajo;
        }

        public static explicit operator Docente (Alumno auxAlumno)
        {
            return new Docente(auxAlumno.GetDni(), auxAlumno.GetNombre(), auxAlumno.GetApellido(), auxAlumno.GetLegajo());
        }
    }


}
