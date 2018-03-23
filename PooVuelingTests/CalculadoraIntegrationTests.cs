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
        [DataTestMethod] // permite enviar datos al método de test (parametrizar)
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1,num2) == resultado);
        }

        [DataRow(2,3,6)]
        [DataRow(5,7,35)]
        [DataTestMethod]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [DataRow(34,8,26)]
        [DataRow(50,29,21)]
        [DataTestMethod]
        public void RestaTest(int num1, int num2, int resultado)
        {            
            int actual = iCalculadora.Resta(num1, num2);
            Assert.AreEqual(resultado, actual);
        }

        [DataRow(45,53,98)]
        [DataRow(87,35,122)]
        [DataTestMethod]
        public void SumaTest(int num1, int num2, int resultado)
        {
            //int expected = 5;                      
            //int actual = iCalculadora.Suma(2,3);
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}