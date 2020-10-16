using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    public class MotoCross : VehiculoDeCarrera
    {
        short cilindrada; 

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1.Equals(a2) && a1.cilindrada == a2.cilindrada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
