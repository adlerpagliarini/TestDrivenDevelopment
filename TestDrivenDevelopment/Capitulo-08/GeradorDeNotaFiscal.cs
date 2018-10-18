using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_08
{
    public class GeradorDeNotaFiscal
    {
        /*private NotaFiscalDAO _notaFiscalDAO { get; }
        private SAP _sap { get; }*/
        private IList<IAcaoAposGerarNota> _acaoAposGerarNotaFiscal;
        private IRelogio _relogio { get; }
        private ITabelaTaxaDeImposto _taxaDeImposto;


        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acaoAposGerarNotaFiscal, IRelogio relogio, ITabelaTaxaDeImposto tabelaTaxaDeImposto)
        {
            _acaoAposGerarNotaFiscal = acaoAposGerarNotaFiscal;
            _relogio = relogio;
            _taxaDeImposto = tabelaTaxaDeImposto;
        }

        public NotaFiscal GerarNotaFiscal(Pedido pedido)
        {
            var valor = pedido.ValorTotal * _taxaDeImposto.ImpostoParaValor(pedido.ValorTotal);
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, valor, _relogio.AbstracaoDeMetodoStaticDateTime());
            _acaoAposGerarNotaFiscal.ToList().ForEach(a => a.AcaoAposGerarNotaFiscal(nf));

            return nf;
        }
    }
}
