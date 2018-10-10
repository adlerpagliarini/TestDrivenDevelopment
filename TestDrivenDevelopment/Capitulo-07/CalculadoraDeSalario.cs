using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_07
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            return funcionario.Cargo.RegraDeCalculo.CalculaDescontoSalario(funcionario);
        }
    }
}
