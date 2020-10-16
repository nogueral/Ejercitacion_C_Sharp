using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        public Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (c.competidores.Contains(a))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                Random auxRandom = new Random();
                a.CantCombustible = (short)auxRandom.Next(15, 100);
                return true;
            }

            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            return c.competidores.Remove(a);
            
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad Competidores {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad Vueltas: {this.cantidadVueltas}");
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendLine(string.Format(item.MostrarDatos()));
            }
            return sb.ToString();
        }
    }


}
