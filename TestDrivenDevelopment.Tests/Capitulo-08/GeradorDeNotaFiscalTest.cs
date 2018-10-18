using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestDrivenDevelopment.Capitulo_08;

namespace TestDrivenDevelopment.Tests.Capitulo_08
{
    [TestFixture]
    public class GeradorDeNotaFiscalTest
    {
        private IList<IAcaoAposGerarNota> _acoesAposGerarNf;
        private Mock<IRelogio> _relogio;
        private Mock<NotaFiscalDAO> nfDAO;
        private Mock<NotaFiscalSAP> nfSAP;
        private Mock<ITabelaTaxaDeImposto> _tabelaTaxaDeImposto;

        [SetUp]
        public void Inicializa()
        {
            //Gerando Mock
            _acoesAposGerarNf = new List<IAcaoAposGerarNota>();

            _relogio = new Mock<IRelogio>();
            _relogio.Setup(r => r.AbstracaoDeMetodoStaticDateTime()).Returns(DateTime.Now);

            nfDAO = new Mock<NotaFiscalDAO>();
            nfSAP = new Mock<NotaFiscalSAP>();

            _tabelaTaxaDeImposto = new Mock<ITabelaTaxaDeImposto>();
            _tabelaTaxaDeImposto.Setup(t => t.ImpostoParaValor(1000.0)).Returns(0.2);
        }

        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(_acoesAposGerarNf, _relogio.Object, _tabelaTaxaDeImposto.Object);
            Pedido pedido = new Pedido("Capitulo08", 1000.0, 1);
            NotaFiscal nf = geradorDeNotaFiscal.GerarNotaFiscal(pedido);
            _tabelaTaxaDeImposto.Verify(t => t.ImpostoParaValor(1000.0));

            Assert.AreEqual(1000 * 0.2, nf.Valor, 0.0001);
        }

        [Test]
        public void ValidaExecucaoDaClasseNotaFiscalDAO()
        {
            _acoesAposGerarNf.Add(nfDAO.Object);
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(_acoesAposGerarNf, _relogio.Object, _tabelaTaxaDeImposto.Object);
            Pedido pedido = new Pedido("Capitulo08", 1000.0, 1);
            NotaFiscal nf = geradorDeNotaFiscal.GerarNotaFiscal(pedido);

            nfDAO.Verify(t => t.AcaoAposGerarNotaFiscal(nf));
        }


        [Test]
        public void ValidaExecucaoDaClasseSAP()
        {
            _acoesAposGerarNf.Add(nfSAP.Object);
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(_acoesAposGerarNf, _relogio.Object, _tabelaTaxaDeImposto.Object);
            Pedido pedido = new Pedido("Capitulo08", 1000.0, 1);
            NotaFiscal nf = geradorDeNotaFiscal.GerarNotaFiscal(pedido);

            nfSAP.Verify(t => t.AcaoAposGerarNotaFiscal(nf));
        }

        [Test]
        public void ValidaExecucaoDoRelogio()
        {
            _acoesAposGerarNf.Add(nfSAP.Object);
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(_acoesAposGerarNf, _relogio.Object, _tabelaTaxaDeImposto.Object);
            Pedido pedido = new Pedido("Capitulo08", 1000.0, 1);
            NotaFiscal nf = geradorDeNotaFiscal.GerarNotaFiscal(pedido);

            _relogio.Verify(t => t.AbstracaoDeMetodoStaticDateTime());
        }

    }
}
