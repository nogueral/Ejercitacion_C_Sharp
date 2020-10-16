using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        short cantidadCompetidores;
        short cantidadVueltas;
        TipoCompetencia tipo;
        List<VehiculoDeCarrera> competidores;

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        internal TipoCompetencia Tipo { get => tipo; set => tipo = value; }

        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        public Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if (c.competidores.Contains(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            if(c.tipo == TipoCompetencia.F1 && a is AutoF1 || c.tipo == TipoCompetencia.MotoCross && a is MotoCross)
            {
                if (c.competidores.Count < c.CantidadCompetidores && c != a)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.CantidadVueltas;
                    Random auxRandom = new Random();
                    a.CantCombustible = (short)auxRandom.Next(15, 100);
                    return true;

                } 

            } 

            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            return c.competidores.Remove(a);

        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nTipo competencia: {this.tipo.ToString()}");
            sb.AppendLine($"Cantidad Competidores {this.CantidadCompetidores}");
            sb.AppendLine($"Cantidad Vueltas: {this.CantidadVueltas}\n");
            foreach (VehiculoDeCarrera item in this.competidores)
            {
                sb.AppendLine(string.Format(item.MostrarDatos()));
            }
            return sb.ToString();
        }
    }
}
