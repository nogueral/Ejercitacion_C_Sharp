using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    class SinEspacioException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase { get { return this.nombreClase; } }

        public string NombreMetodo { get { return this.nombreMetodo; } }


        public SinEspacioException(string mensaje, string nombreClase, string nombreMetodo) : base(mensaje)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******************************");
            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine(this.Message);
            sb.AppendLine("******************************");

            return sb.ToString();
        }
    }
}
