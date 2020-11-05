﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        List<Llamada> listaLlamadas;
        string razonSocial;
        string ruta;

        private Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulador = 0;

            foreach (Llamada item in this.listaLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (item is Local)
                        acumulador += ((Local)item).CostoLlamada;
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (item is Provincial)
                        acumulador += ((Provincial)item).CostoLlamada;
                }
            }

            return acumulador;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine(String.Format("Ganancia total: ${0:#,###.00}", this.GananciasPorTotal));
            sb.AppendLine(String.Format("Ganancia llamadas locales: ${0:#,###.00}", this.GananciasPorLocal));
            sb.AppendLine(String.Format("Ganancia llamadas provinciales: ${0:#,###.00}", this.GananciasPorProvincial));
            sb.AppendLine("\n");

            foreach (var item in this.listaLlamadas)
            {
                if(item is Local)
                {
                    sb.AppendLine(((Local)item).ToString());
                }

                if (item is Provincial)
                {
                    sb.AppendLine(((Provincial)item).ToString());
                }
            }
            

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada item in c.Llamadas)
            {
                if (item == llamada)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
                c.Guardar();
                return c;

            } else
            {
                throw new CentralitaException("La llamada ya se encuentra registrada", "clase", "metodo");
            }

            
        }

        public bool Guardar()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(this.RutaDeArchivo, true))
                {
                    writer.WriteLine(String.Format($"{DateTime.Now.DayOfWeek.ToString()} {DateTime.Now.ToString("dd MMMM, yyyy HH:mm")}hs - Se realizo una llamada"));

                    return true;
                }
            }
            catch (Exception)
            {

                throw new Exception("No se pudo guardar el archivo");
            }




        }

        public string Leer()
        {
            string dato;

            using(StreamReader reader = new StreamReader(this.RutaDeArchivo))
            {
                dato = reader.ReadToEnd();
            }

            return dato;
        }

        public string RutaDeArchivo
        {
            get 
            {
                this.ruta = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "archivo");
                return this.ruta;
            }

            set { this.ruta = value; }
        }
    }
}
