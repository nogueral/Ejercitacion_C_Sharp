using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punta_de_Caja
{
    public class Factura
    {
        float precio;
        int numero;

        public Factura()
        {

        }
        public Factura(float precio, int numero)
        {
            this.Precio = precio;
            this.Numero = numero;
        }

        public float Precio { get => precio; set => precio = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
