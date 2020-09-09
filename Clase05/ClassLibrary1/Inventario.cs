using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Inventario
    {
        static Producto[] listaProductos;
        static Inventario()
        {
            listaProductos = new Producto[13];
        }

        public static void HardcodeoProductos()
        {
            string[] descripcion = new string[10] { "Ladrillo", "Flexible caño", "Destornillador", "Canillas", "Bombillas", "Bolsa arena", "Caños agua", "Martillo", "Pinza", "Cable (por metro)" };
            string[] codigo = new string[10] { "12", "10", "15", "11", "4", "90", "1", "31", "9", "7" };
            float[] precio = new float[10] { 80, 100, 95, 45, 20, 60, 100, 120, 135, 50 };
            int[] uStock = new int[10] { 120, 5, 124, 15, 300, 45, 20, 150, 80, 98 };
            int[] uVendidas = new int[10] { 50, 495, 13, 1200, 100, 1500, 500, 95, 25, 30 };

            for (int i = 0; i < 10; i++)
            {
                listaProductos[i] = new Producto(codigo[i], descripcion[i], precio[i], uStock[i], uVendidas[i]);
            }
        }


    }
}
