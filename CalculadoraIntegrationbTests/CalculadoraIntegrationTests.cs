using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;

namespace CalculadoraIntegrationbTests
{
    [TestClass]
    public class CalculadoraIntegrationTests
    {
        [TestMethod]
        public void TestSuma()
        {
            int expected = 5;
            ICalculadora calculadora = new Calculadora();
            int actual = calculadora.Suma(2,3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestResta()
        {
            int expected = 5;
            ICalculadora calculadora = new Calculadora();
            int actual = calculadora.Suma(2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplicacion()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void TestDivision()
        {
            Assert.Fail();
        }
    }
}
