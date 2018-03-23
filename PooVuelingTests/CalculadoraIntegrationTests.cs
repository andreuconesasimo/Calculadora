using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraIntegrationTests
    {
        ICalculadora iCalculadora = new Calculadora();

        //[TestMethod()]
        [DataRow(4,2,2)] // cada data row es una casuistica
        [DataRow(9,3,3)] // 9/3 = 3
        [DataTestMethod] // permite enviar datos al método de test
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1,num2) == resultado);
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