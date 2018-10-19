using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDrivenDevelopment.Capitulo_09;

namespace TestDrivenDevelopment.Tests.Capitulo_09
{
    [TestFixture]
    public class FaturaTest
    {
        [Test]
        public void DeveAdicionarBoletoNaFatura()
        {
            var fatura = new Fatura("Cliente", 150.0);
            var boleto = new Boleto(150.0);

            Pagamento pagamento = new Pagamento(boleto.ValorPago, TipoPagamento.Boleto);
            fatura.AdicionaPagamento(pagamento);

            Assert.AreEqual(1, fatura.Pagamentos.Count);
            Assert.AreEqual(150.0, fatura.Pagamentos[0].Valor, 0.00001);

        }

        [Test]
        public void DeveMarcarFaturaComoPagaCasoValorPagamentoSejaMaiorOuIgualValorDaFatura()
        {
            var fatura = new Fatura("Cliente", 150.0);
            var boleto = new Boleto(150.0);

            Pagamento pagamento = new Pagamento(boleto.ValorPago, TipoPagamento.Boleto);
            fatura.AdicionaPagamento(pagamento);

            Assert.IsTrue(fatura.Pago);
        }
    }
}
