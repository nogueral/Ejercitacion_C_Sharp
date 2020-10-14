using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzzFest
{
    public class Plomo : Personal
    {
        string cargo;

        public Plomo(string cargo, string nombre, string apellido): base(nombre, apellido)
        {
            this.cargo = cargo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EMPLEADO - SOPORTE");
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.cargo);

            return sb.ToString();
        }
    }
}
