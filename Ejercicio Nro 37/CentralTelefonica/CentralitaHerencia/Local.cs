using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        float costo;

        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) :base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: ${this.CostoLlamada}");
           

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.duracion * this.costo;
        }
    }
}
