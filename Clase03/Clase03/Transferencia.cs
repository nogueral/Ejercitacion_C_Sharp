using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Transferencia
    {
        private static int cotizacion;
        private static int cantidadTransferencias;
        private double montoOrigen;
        private double montoDestino;

        //constructor de clase, es el primero q se ejecuta cuando se crea un objeto
        static Transferencia()
        {
            cotizacion = 100;
            cantidadTransferencias = 0;
        }

        // constructor de instancia
        public Transferencia()
        {
            this.montoOrigen = 50 * cotizacion;
            this.montoDestino = 100 * cotizacion;
            cantidadTransferencias++;
        }

        public int GetCantTransferencias()
        {
            return cantidadTransferencias;
        }
    }
}
