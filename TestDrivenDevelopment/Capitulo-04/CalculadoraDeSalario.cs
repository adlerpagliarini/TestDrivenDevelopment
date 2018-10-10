using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_04
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            switch (funcionario.Cargo)
            {
                case Cargo.DESENVOLVEDOR:
                    return funcionario.Salario <= 3000 ? funcionario.Salario * 0.9 : funcionario.Salario * 0.8;
                case Cargo.DBA:
                case Cargo.TESTADOR:
                    return funcionario.Salario <= 2500 ? funcionario.Salario * 0.85 : funcionario.Salario * 0.75;
                default:
                    return 0;
            }
        }
    }
}
