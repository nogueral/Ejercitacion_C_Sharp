using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Factura factura = new Factura(1800);

            c += factura;

            Recibo recibo = new Recibo(1800);

            c += recibo;
        }
    }
}
