using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo._10.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; private set; }

        public Produto()
        {
            this.Ativo = true;
        }

        public void Ativa()
        {
            this.Ativo = true;
        }

        public void Inativa()
        {
            this.Ativo = false;
        }
    }
}
