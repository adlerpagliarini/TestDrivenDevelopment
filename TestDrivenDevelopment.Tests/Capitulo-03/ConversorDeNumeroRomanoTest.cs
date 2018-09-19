using NUnit.Framework;
using TestDrivenDevelopment;

namespace TestDrivenDevelopment.Tests
{
	public class ConversorDeNumeroRomanoTest
    {
        [Test]
        public void DeveEntenderSimbolo_I()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderSimbolo_V()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderSimbolo_X()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("X");
            Assert.AreEqual(10, numero);
        }

        [Test]
        public void DeveEntenderSimbolos_II()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderSimbolos_VV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("VV");
            Assert.AreEqual(10, numero);
        }

        [Test]
        public void DeveEntenderSimbolos_XX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XX");
            Assert.AreEqual(20, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimbolosDoisADois_XXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderSimbolos_IX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [Test]
        public void DeveEntenderSimbolosComplexos_XXIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }
    }
}