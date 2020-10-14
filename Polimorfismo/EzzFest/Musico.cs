using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EzzFest
{
    public class Musico : Personal
    {

        EInstumento instrumento;

        public Musico(string nombre, string apellido, EInstumento instrumento):base(nombre, apellido)
        {

            this.instrumento = instrumento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MUSICO");
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.instrumento.ToString());

            return sb.ToString();
        }
    }
}
