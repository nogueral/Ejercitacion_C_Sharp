using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ItemFactura
    {
        Producto auxProducto;
        int cantidad;
        double precioUnitario;

        public int GetCantidad()
        {
            return this.cantidad;
        }

        public double GetPrecio()
        {
            return this.precioUnitario;
        }

        public static implicit operator ItemFactura(Producto miProducto)
        {
            ItemFactura itemFactura = new ItemFactura();
            itemFactura.auxProducto = miProducto;
            itemFactura.precioUnitario = miProducto.GetPrecio();
            return itemFactura;
        }
    }
}
