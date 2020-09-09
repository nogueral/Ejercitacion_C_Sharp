using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
    {
        string codigo;
        string descripcion;
        float precio;
        int uStock;
        int uVendidas;

        public Producto(string codigo, string descripcion, float precio, int uStock, int uVendidas)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.uStock = uStock;
            this.uVendidas = uVendidas;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

    }
}
