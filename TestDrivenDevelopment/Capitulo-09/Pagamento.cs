namespace TestDrivenDevelopment.Capitulo_09
{
    public class Pagamento
    {
        public double Valor { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        public Pagamento(double valor, TipoPagamento tipoPagamento)
        {
            Valor = valor;
            TipoPagamento = TipoPagamento;
        }
    }
}
