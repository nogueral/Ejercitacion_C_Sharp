using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador_Nro_1
{
    class Facturacion
    {
        string nombre;
        int idProducto;
        double facturacion;

        public Facturacion()
        {
            this.nombre = "Sin nombre";
            this.idProducto = -1;
            this.facturacion = -1;
        }

        public Facturacion(string nombre, int idProducto, double facturacion):this()
        {
            this.nombre = nombre;
            this.idProducto = idProducto;
            this.facturacion = facturacion;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetIdProducto()
        {
            return this.idProducto;
        }

        public double GetFacturacion()
        {
            return this.facturacion;
        }

        public static explicit operator Facturacion(Producto auxProducto)
        {
            return new Facturacion(auxProducto.GetNombre(), auxProducto.GetIdProducto(), auxProducto.GetPrecio() * auxProducto.GetCantVendidos());
        }
    }
}
