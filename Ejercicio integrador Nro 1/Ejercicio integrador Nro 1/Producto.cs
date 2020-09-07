using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador_Nro_1
{

#pragma warning disable CS0660
#pragma warning disable CS0661
    class Producto
    {
        string nombre;
        int idProducto;
        string categoria;
        double precio;
        string stockActual;
        int cantidadVendidos;

        public Producto()
        {
            this.nombre = "sin nombre";
            this.idProducto = -1;
            this.categoria = "sin categoria";
            this.precio = -1;
            this.stockActual = "-1";
            this.cantidadVendidos = -1;
        }

        public Producto(string nombre, int idProducto, string categoria): this()
        {
            this.nombre = nombre;
            this.idProducto = idProducto;
            this.categoria = categoria;
        }

        public Producto(string nombre, int idProducto, string categoria, double precio, string stockActual, int cantidadVendidos) : this(nombre, idProducto, categoria)
        {
            this.precio = precio;
            this.stockActual = stockActual;
            this.cantidadVendidos = cantidadVendidos;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public int GetIdProducto()
        {
            return this.idProducto;
        }

        public void SetId(int auxId)
        {
            this.idProducto = auxId;
        }

        public string GetStock()
        {
            return this.stockActual;
        }

        public void SetStock(string auxStock)
        {
            this.stockActual = auxStock;
        }

        public double GetPrecio()
        {
            return this.precio;
        }

        public void SetPrecio(double auxPrecio)
        {
            this.precio = auxPrecio;
        }

        public string GetCategoria()
        {
            return this.categoria;
        }

        public void SetCategoria(string auxCategoria)
        {
            this.categoria = auxCategoria;
        }

        public int GetCantVendidos()
        {
            return this.cantidadVendidos;
        }

        public void SetCantidadVendidos(int auxCantidad)
        {
            this.cantidadVendidos = auxCantidad;
        }


        public static bool operator == (Producto[] auxLista, Producto auxProducto)
        {
            bool retorno = false;

            for (int i = 0; i < auxLista.Length; i++)
            {
                if(auxLista[i] != null && auxLista[i].GetIdProducto() == auxProducto.GetIdProducto())
                {
                    retorno = true;
                    break;
                }
            }


            return retorno;
        }

        public static bool operator !=(Producto[] auxLista, Producto auxProducto)
        {
            return !(auxLista == auxProducto);
        }

        public static bool operator +(Producto[] auxLista, Producto auxProducto)
        {
            bool retorno = false;

            if (auxLista != auxProducto)
            {
                for (int i = 0; i < auxLista.Length; i++)
                {
                    if (auxLista[i] == null)
                    {
                        auxLista[i] = auxProducto;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator -(Producto[] auxLista, Producto auxProducto)
        {
            bool retorno = false;

            if (auxLista == auxProducto)
            {
                for (int i = 0; i < auxLista.Length; i++)
                {
                    if (auxLista[i] != null && auxLista[i].GetIdProducto() == auxProducto.GetIdProducto()) 
                    {
                        auxLista[i] = null;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

    }
}
