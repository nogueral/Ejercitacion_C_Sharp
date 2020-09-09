using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermedad
    {
        string nombre;
        string[] sintomas;

        private Enfermedad()
        {
            sintomas = new string[5];
        }

        public Enfermedad(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Enfermedad(string nombre, string[] sintomas):this(nombre)
        {
            this.sintomas = sintomas;
        }

    }
}
