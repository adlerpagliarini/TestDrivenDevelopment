using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDrivenDevelopment.Capitulo_09;

namespace TestDrivenDevelopment.Tests.Capitulo_09
{
    [TestFixture]
    public class ProcessadorDeBoletosTest
    {
        [Test]
        public void DeveProcessarPagamentoViaBoletoUnico()
        {
            var processadorDeBoleto = new ProcessadorDeBoletos();
            var fatura = new Fatura("Cliente", 150.0);
            var boleto = new Boleto(150.0);
            IList<Boleto> boletos = new List<Boleto>();
            boletos.Add(boleto);

            processadorDeBoleto.ProcessaBoletos(boletos, fatura);

            Assert.AreEqual(1, fatura.Pagamentos.Count);
            Assert.AreEqual(150.0, fatura.Pagamentos[0].Valor, 0.00001);

        }

        [Test]
        public void DeveProcessarPagamentoViaMultiplosBoletos()
        {
            var processadorDeBoleto = new ProcessadorDeBoletos();
            var fatura = new Fatura("Cliente", 350.0);
            var boleto1 = new Boleto(150.0);
            var boleto2 = new Boleto(200.0);

            IList<Boleto> boletos = new List<Boleto>();
            boletos.Add(boleto1);
            boletos.Add(boleto2);

            processadorDeBoleto.ProcessaBoletos(boletos, fatura);

            Assert.AreEqual(2, fatura.Pagamentos.Count);

            var valorDasFaturas = fatura.Pagamentos.Aggregate(0.0, (acc, pagamento) => acc += pagamento.Valor);
            Assert.AreEqual(350.0, valorDasFaturas, 0.00001);

        }

    }
}
