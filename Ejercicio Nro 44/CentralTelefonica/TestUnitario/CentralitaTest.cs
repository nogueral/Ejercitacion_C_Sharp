using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitario
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        public void TestValidarConstructor()
        {
            Centralita auxCentralita = new Centralita("Test");

            Assert.IsNotNull(auxCentralita.Llamadas);
        }
    }
}
