using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Alumno
    {
        string nombre;
        int legajo;

        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetLegajo(int auxLegajo)
        {
            this.legajo = auxLegajo;
        }

        public int GetLegajo()
        {
            return this.legajo;
        }
    }
}
