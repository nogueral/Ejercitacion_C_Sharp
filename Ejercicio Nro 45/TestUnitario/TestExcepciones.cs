using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_MetodoEstatico()
        {
            MiClase.MetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_MiClase()
        {
            MiClase auxClase;

            auxClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test_MiClaseString()
        {
            MiClase auxClase;

            auxClase = new MiClase("Test");
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Test_OtraClase()
        {
            OtraClase auxClase = new OtraClase();

            auxClase.MetodoInstancia();
        }
    }
}
