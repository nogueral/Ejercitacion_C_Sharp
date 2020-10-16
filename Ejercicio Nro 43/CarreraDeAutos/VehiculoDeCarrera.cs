using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAutos
{
    public abstract class VehiculoDeCarrera
    {
        short cantCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
            this.EnCompetencia = false;
            this.CantCombustible = 0;
            this.VueltasRestantes = 0;
        }

        public short CantCombustible { get => cantCombustible; set => cantCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Escuderia: {this.escuderia}"));
            sb.AppendLine(string.Format($"Numero: {this.numero}"));
            sb.AppendLine(string.Format($"Cantidad Combustible: {this.CantCombustible}"));
            sb.AppendLine(string.Format($"Vueltas Restantes: {this.VueltasRestantes}"));

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(obj is VehiculoDeCarrera)
            {
                if(this.Escuderia == ((VehiculoDeCarrera)obj).Escuderia && this.Numero == ((VehiculoDeCarrera)obj).Numero)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
