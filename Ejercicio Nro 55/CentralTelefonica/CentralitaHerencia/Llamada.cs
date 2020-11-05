﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;

            } else if (llamada1.duracion == llamada2.duracion)
            {
                return 0;

            } else 
            {
                return -1;
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion de la llamada: {this.duracion}");
            sb.AppendLine($"Numero origen: {this.nroOrigen}");
            sb.Append($"Numero destino: {this.nroDestino}");
            

            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1.NroOrigen==l2.nroOrigen && l1.nroDestino==l2.nroDestino && l1.Equals(l2))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
