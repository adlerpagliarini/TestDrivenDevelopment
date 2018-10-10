using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_07
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }
    }
}
