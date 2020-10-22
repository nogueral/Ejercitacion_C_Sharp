using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarreraDeAutos;

namespace TestUnitario
{
    [TestClass]
    public class TestCarreras
    {
        [TestMethod]
        public void Test_ListaCompetidores()
        {
            Competencia c = new Competencia(5, 6, Competencia.TipoCompetencia.F1);

            Assert.IsNotNull(c.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test_CompetenciaNoDisponible()
        {
            Competencia c = new Competencia(5, 6, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(5, "Ford");

            bool retorno = c + a1;
        }

        [TestMethod]
        public void Test_CargaMotocross()
        {
            Competencia c = new Competencia(5, 6, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(8, "Bajaj");

            try
            {
                bool retorno = c + m1;
                Assert.IsTrue(retorno);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [TestMethod]
        public void Test_VehiculoEnLista()
        {
            Competencia c = new Competencia(5, 6, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(8, "Bajaj");
            bool carga;
            bool verificacion = false;

            carga = c + m1;

            foreach (VehiculoDeCarrera item in c.Competidores)
            {
                if(item is MotoCross && (MotoCross)item == m1)
                {
                    verificacion = true;
                    break;
                }
            }

            Assert.AreEqual(carga, verificacion);
        }

        [TestMethod]
        public void Test_VehiculoEliminado()
        {
            Competencia c = new Competencia(5, 6, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(8, "Bajaj");
            bool carga;
            bool verificacion = false;

            carga = c + m1;
            carga = c - m1;

            foreach (VehiculoDeCarrera item in c.Competidores)
            {
                if (item is MotoCross && (MotoCross)item == m1)
                {
                    verificacion = true;
                    break;
                }
            }

            Assert.AreNotEqual(carga, verificacion);
        }
    }
}
