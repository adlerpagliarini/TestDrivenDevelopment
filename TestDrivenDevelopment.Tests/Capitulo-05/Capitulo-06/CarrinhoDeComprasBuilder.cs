using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Tests
{ 
    // Test Data Builder
    public class CarrinhoDeComprasBuilder
    {
        public CarrinhoDeCompras carrinho;

        public CarrinhoDeComprasBuilder()
        {
            carrinho = new CarrinhoDeCompras();
        }
        public CarrinhoDeCompras Cria()
        {
            return carrinho;
        }
        public CarrinhoDeComprasBuilder ComItens(params double[] valores)
        {
            foreach (double valor in valores)
            {
                carrinho.Adiciona(new Item("item", 1, valor));
            }
            return this;
        }
    }
}
