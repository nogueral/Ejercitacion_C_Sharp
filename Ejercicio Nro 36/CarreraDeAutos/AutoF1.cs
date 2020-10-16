using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    public class AutoF1 : VehiculoDeCarrera
    {
        short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");

            return sb.ToString();
        }

        public short CaballosDeFuerza { get => caballosDeFuerza; set => caballosDeFuerza = value; }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.Equals(a2) && a1.caballosDeFuerza == a2.caballosDeFuerza)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


    }
}
