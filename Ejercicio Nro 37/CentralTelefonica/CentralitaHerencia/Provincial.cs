using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        Franja franjaHoraria;

        public Provincial(Franja franjaHoraria, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.duracion * 0.99f;

                case Franja.Franja_2:
                    return this.duracion * 1.25f;

                case Franja.Franja_3:
                    return this.duracion * 0.66f;

                default:
                    return 0;

            }


        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: ${this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria.ToString()}");
           

            return sb.ToString();
        }
    }
}
