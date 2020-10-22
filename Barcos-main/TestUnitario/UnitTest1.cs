using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProbarBarcoAmigo()
        {
            BarcoAmigo barcoTest = null;

            Assert.IsNull(barcoTest);
        }

        [TestMethod]
        public void TestearBarcoEnemigo()
        {
            BarcoEnemigo barcoTest = new BarcoEnemigo(10, 10, 3, 3);

            Assert.IsNull(barcoTest);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "No tiro excepcion, esperaba NullReferenceException")]
        public void ProbarNullReferenceBarco()
        {
            throw new NullReferenceException();

            // solo funciona si devuelve el null reference, si devuelve "exception" rompe aunque exista herencia
        }
    }
}
