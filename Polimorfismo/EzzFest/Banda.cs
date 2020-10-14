using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EzzFest
{
    class Banda
    {
        List<Musico> listaMusicos;
        int cantidadCanciones;
        double tiempoTotal;

        private Banda()
        {
            listaMusicos = new List<Musico>();
        }

        public Banda(List<Musico> listaMusicos, int cantidadCanciones, double tiempoTotal) :this()
        {
            this.listaMusicos = listaMusicos;
            this.cantidadCanciones = cantidadCanciones;
            this.tiempoTotal = tiempoTotal;
        }

        public double Tiempo
        {
            get { return this.tiempoTotal; }
        }
    }
}
