using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    #pragma warning disable CS0660
    #pragma warning disable CS0661
    class Alumno
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int legajo;
        private string curso;

        public Alumno(string nombre, string apellido, int dni):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        private Alumno()
        {
            this.dni = -1;
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.legajo = -1;
            this.curso = "sin sala";
        }

        public Alumno(string nombre, string apellido, int dni, int legajo) : this(nombre, apellido, dni)
        {
            this.legajo = legajo;


        }

        public Alumno(string nombre, string apellido, int dni, int legajo, string curso) : this(nombre, apellido, dni, legajo)
        {

            this.curso = curso;

        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public string GetCurso()
        {
            return this.curso;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public int GetLegajo()
        {
            return this.legajo;
        }


        public static bool operator ==(Alumno[] arrayAux, Alumno auxEstudiante)
       {
           bool retorno = false;

           for (int i = 0; i < arrayAux.Length; i++)
           {
               if(arrayAux[i] != null && auxEstudiante != null && arrayAux[i].dni == auxEstudiante.dni)
               {
                   retorno = true;
                   break;
               }
           }

           return retorno;
       }


       public static bool operator !=(Alumno[] arrayAux, Alumno auxEstudiante)
       {
           return !(arrayAux == auxEstudiante);
       }

       public static bool operator +(Alumno[] arrayAux, Alumno auxEstudiante)
       {
           bool retorno = false;

           if(arrayAux != auxEstudiante)
           {
               for(int i = 0; i < arrayAux.Length; i++)
               {
                   if (arrayAux[i] == null)
                   {
                       arrayAux[i] = auxEstudiante;
                       retorno = true;
                       break;
                   }
               }
           }

           return retorno;
       }

        public static bool operator -(Alumno[] arrayAux, Alumno auxEstudiante)
        {
            bool retorno = false;

            if (arrayAux == auxEstudiante)
            {
                for (int i = 0; i < arrayAux.Length; i++)
                {
                    if (arrayAux[i] != null && auxEstudiante != null && arrayAux[i].dni == auxEstudiante.dni)
                    {
                        arrayAux[i] = null;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static implicit operator Alumno  (Docente auxDocente)
        {
            return new Alumno(auxDocente.GetNombre(), auxDocente.GetApellido(), auxDocente.GetDni(), auxDocente.GetLegajo());
        }
    }
}
