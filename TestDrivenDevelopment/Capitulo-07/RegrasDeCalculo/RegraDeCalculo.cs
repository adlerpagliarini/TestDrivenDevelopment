using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_07
{
    public abstract class RegraDeCalculo : IRegraDeCalculo
    {
        public double CalculaDescontoSalario(Funcionario funcionario)
        {
            return funcionario.Salario <= Limite() ? funcionario.Salario * PorcentagemBase() : funcionario.Salario * PorcentagemAcimaDoLimite();
        }

        protected abstract int Limite();
        protected abstract double PorcentagemAcimaDoLimite();
        protected abstract double PorcentagemBase();
    }
}
