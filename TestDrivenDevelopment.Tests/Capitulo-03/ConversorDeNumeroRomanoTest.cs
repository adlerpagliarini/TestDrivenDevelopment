using NUnit.Framework;
using TestDrivenDevelopment;

namespace TestDrivenDevelopment.Tests
{
	public class ConversorDeNumeroRomanoTest
    {
        [Test]
        public void DeveEntenderSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderSimboloX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("X");
            Assert.AreEqual(10, numero);
        }
    }
}