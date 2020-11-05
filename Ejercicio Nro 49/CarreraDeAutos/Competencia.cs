using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        short cantidadCompetidores;
        short cantidadVueltas;
        TipoCompetencia tipo;
        List<T> competidores;

        public List<T> Competidores
        {
            get { return this.competidores; }
        }


        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        internal TipoCompetencia Tipo { get => tipo; set => tipo = value; }

        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        private Competencia()
        {
            competidores = new List<T>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }

        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            if (c.tipo == TipoCompetencia.F1 && a is AutoF1 || c.tipo == TipoCompetencia.MotoCross && a is MotoCross)
            {
                return true;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Sobrecarga ==");
            }
        }

        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if(item is MotoCross && item == a)
                {
                    throw new VehiculoPreviamenteCargadoException("Vehiculo previamente cargado", "Competencia", "Sobrecarga !=");
                }

                if (item is AutoF1 && item == a)
                {
                    throw new VehiculoPreviamenteCargadoException("Vehiculo previamente cargado", "Competencia", "Sobrecarga !=");
                }
            }

            return true;

        }

        public static bool operator +(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool retorno; 

            try
            {
                retorno = c == a;

            }
            catch (Exception e)
            {

                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga +", e);
            }


            if (c.competidores.Count < c.CantidadCompetidores && c != a)
            {
                c.competidores.Add((T)a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.CantidadVueltas;
                Random auxRandom = new Random();
                a.CantCombustible = (short)auxRandom.Next(15, 100);
                return true;

            } else
            {
                throw new SinEspacioException("No hay mas espacio para agregar competidores", "Competencia", "Sobrecarga +");
            }


        }

        public static bool operator -(Competencia<T> c, VehiculoDeCarrera a)
        {
            return c.competidores.Remove((T)a);

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
