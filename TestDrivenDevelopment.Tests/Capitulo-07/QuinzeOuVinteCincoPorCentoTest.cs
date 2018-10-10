using NUnit.Framework;
using TestDrivenDevelopment.Capitulo_07;

namespace TestDrivenDevelopment.Tests.Capitulo_07
{
    [TestFixture]
    public class QuinzeOuVinteCincoPorCentoTest
    {
        [Test]
        public void CalculaDescontoSalarioComSalarioAbaixoDoLimite()
        {
            QuinzeOuVinteCincoPorCento quinzeOuVinteCincoPorCento = new QuinzeOuVinteCincoPorCento();
            Funcionario dba = new Funcionario("Adler", 1500.0, Cargo.DBA);            
           
            var salario = quinzeOuVinteCincoPorCento.CalculaDescontoSalario(dba);
            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void CalculaDescontoSalarioComSalarioAcimaDoLimite()
        {
            QuinzeOuVinteCincoPorCento quinzeOuVinteCincoPorCento = new QuinzeOuVinteCincoPorCento();
            Funcionario dba = new Funcionario("Adler", 3001.0, Cargo.DBA);

            var salario = quinzeOuVinteCincoPorCento.CalculaDescontoSalario(dba);
            Assert.AreEqual(3001.0 * 0.75, salario, 0.00001);
        }
    }
}
