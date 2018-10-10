namespace TestDrivenDevelopment.Capitulo_07
{
    public class Cargo
    {
        public static Cargo DESENVOLVEDOR { get { return new Cargo(new DezOuVintePorCento()); }}
        public static Cargo DBA { get { return new Cargo(new QuinzeOuVinteCincoPorCento()); } }
        public static Cargo TESTADOR { get { return new Cargo(new QuinzeOuVinteCincoPorCento()); } }

        public IRegraDeCalculo RegraDeCalculo { get; }
        public Cargo(IRegraDeCalculo regraDeCalculo)
        {
            RegraDeCalculo = regraDeCalculo;
        }
    }
}

/*
 * Agora, para forçar o desenvolvedor a sempre definir
    uma regra de cálculo  para  todo  e  qualquer  novo  cargo,  
    podemos forçá-lo  a decidir  isso  na  própria  enumeração  de  Cargo.
   Se  fizermos  esse cargo virar uma classe, conseguimos forçá-la a sempre receber uma estratégia de cálculo.
*/