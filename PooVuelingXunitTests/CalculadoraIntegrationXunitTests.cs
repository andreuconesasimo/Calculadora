using PooVueling;
using Xunit;

namespace PooVuelingXunitTests
{
    public class CalculadoraIntegrationXunitTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4, iCalculadora.Suma(1,3));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.NotEqual(5, iCalculadora.Resta(7,3));
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.False(5 == iCalculadora.Division(32,8));
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.True(20 == iCalculadora.Multiplicacion(4,5));
        }

    }
}
