using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestCotabilidad
    {
        [TestMethod]
        public void Test_CargaFactura()
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Factura factura = new Factura(1800);

            c += factura;

        }

        [TestMethod]
        public void Test_CargaRecibo()
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Recibo recibo = new Recibo(1800);

            c += recibo;

        }
    }
}
