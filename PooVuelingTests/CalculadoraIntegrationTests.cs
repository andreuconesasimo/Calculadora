using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraIntegrationTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestMethod()]
        public void DivisionTest()
        {
            Assert.IsTrue(iCalculadora.Division(6,3) == 2);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(2, 3) == 6);
        }

        [TestMethod()]
        public void RestaTest()
        {
            int expected = 1;
            int actual = iCalculadora.Resta(3, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumaTest()
        {
            //int expected = 5;                      
            //int actual = iCalculadora.Suma(2,3);
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(iCalculadora.Suma(2, 3) == 5);
        }
    }
}