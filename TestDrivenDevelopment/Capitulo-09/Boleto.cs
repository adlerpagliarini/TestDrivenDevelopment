namespace TestDrivenDevelopment.Capitulo_09
{
    public class Boleto
    {
        public double ValorPago { get; private set; }

        public Boleto(double valor)
        {
            ValorPago = valor;
        }
    }
}
