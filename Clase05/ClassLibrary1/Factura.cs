using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Factura
    {
        static int contadorFactura;
        int numero;
        string cliente;
        string empresa;
        ItemFactura[] listaItems;
        float total;

        static Factura()
        {
            contadorFactura = 0;
        }

        public Factura()
        {
            contadorFactura++;
            this.numero = contadorFactura;
            this.listaItems = new ItemFactura[20];
        }

        public static bool operator +(Factura factura, ItemFactura item)
        {
            for (int i = 0; i < factura.listaItems.Length; i++)
            {
                if (factura.listaItems[i] != null)
                {
                    factura.listaItems[i] = item;
                }
            }
        }

    }
}
