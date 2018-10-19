using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_09
{
    public class ProcessadorDeBoletos
    {
        public void ProcessaBoletos(IList<Boleto> boletos, Fatura fatura)
        {
            boletos.ToList().ForEach(boleto =>
            {
                Pagamento pagamento = new Pagamento(boleto.ValorPago, TipoPagamento.Boleto);
                fatura.AdicionaPagamento(pagamento);
            });

        }
        /* Versão 1
        public void ProcessaBoletos(IList<Boleto> boletos, Fatura fatura)
        {
            double valorTotal = 0;
            boletos.ToList().ForEach(boleto =>
            {
                Pagamento pagamento = new Pagamento(boleto.ValorPago, TipoPagamento.Boleto);
                fatura.Pagamentos.Add(pagamento);
                valorTotal += boleto.ValorPago;
            });

            if (fatura.Valor >= valorTotal)
                fatura.Pago = true;
        }
        */
    }
}
