using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    public class CompetenciaNoDisponibleException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase { get { return this.nombreClase; } }

        public string NombreMetodo { get { return this.nombreMetodo; } }


        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo):this(mensaje, nombreClase, nombreMetodo, null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException) : base(mensaje, innerException)
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
            Exception auxInnerException = this.InnerException;
            sb.AppendLine("******************************");
            while (auxInnerException != null)
            {
                sb.AppendLine(auxInnerException.ToString());
                auxInnerException = auxInnerException.InnerException;
            }

            return sb.ToString();
        }
    }
}
