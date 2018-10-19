using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestDrivenDevelopment.Capitulo_09
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }


        private List<Pagamento> _pagamentos { get; }
        public IList<Pagamento> Pagamentos
        {
            get { return _pagamentos.ToList().AsReadOnly(); } // It's like return ReadOnlyCollection<Pagamento>
        }

        public bool Pago { get; private set; }

        private double _valorTotalPago => this._pagamentos.Aggregate(0.0, (acc, pagamento) => acc += pagamento.Valor);

        public Fatura(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            _pagamentos = new List<Pagamento>();
            Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this._pagamentos.Add(pagamento);

            if (this.Valor >= this._valorTotalPago)
                this.Pago = true;
        }
    }
}
