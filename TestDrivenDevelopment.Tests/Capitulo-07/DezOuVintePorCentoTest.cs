using NUnit.Framework;
using TestDrivenDevelopment.Capitulo_07;

namespace TestDrivenDevelopment.Tests.Capitulo_07
{
    [TestFixture]
    public class DezOuVintePorCentoTest
    {
        [Test]
        public void CalculaDescontoSalarioComSalarioAbaixoDoLimite()
        {
            DezOuVintePorCento dezOuVintePorCento = new DezOuVintePorCento();
            Funcionario desenvolvedor = new Funcionario("Adler", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = dezOuVintePorCento.CalculaDescontoSalario(desenvolvedor);
            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void CalculaDescontoSalarioComSalarioAcimaDoLimite()
        {
            DezOuVintePorCento dezOuVintePorCento = new DezOuVintePorCento();
            Funcionario desenvolvedor = new Funcionario("Adler", 3001.0, Cargo.DESENVOLVEDOR);

            double salario = dezOuVintePorCento.CalculaDescontoSalario(desenvolvedor);
            Assert.AreEqual(3001.0 * 0.8, salario, 0.00001);
        }
    }
}
