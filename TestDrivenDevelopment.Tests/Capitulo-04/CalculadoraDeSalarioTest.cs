using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestDrivenDevelopment;

namespace TestDrivenDevelopment.Tests
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Adler", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Adler", 3001.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(3001.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Adler", 1500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);
            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Adler", 2501.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);
            Assert.AreEqual(2501.0 * 0.75, salario, 0.00001);
        }
    }
}
