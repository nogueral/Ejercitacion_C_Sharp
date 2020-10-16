using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    class AutoF1
    {
        short cantCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
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

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1.Escuderia == a2.Escuderia && a1.Numero == a2.Numero)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Escuderia: {this.escuderia}"));
            sb.AppendLine(string.Format($"Numero: {this.numero}"));
            sb.AppendLine(string.Format($"Cantidad Combustible: {this.CantCombustible}"));
            sb.AppendLine(string.Format($"Vueltas Restantes: {this.VueltasRestantes}"));

            return sb.ToString();
        }
    }
}
