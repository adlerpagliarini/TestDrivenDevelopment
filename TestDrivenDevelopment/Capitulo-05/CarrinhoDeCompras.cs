using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDrivenDevelopment
{
    public class CarrinhoDeCompras
    {
        public IList<Item> Itens { get; private set; }

        public CarrinhoDeCompras()
        {
            this.Itens = new List<Item>();
        }

        public void Adiciona(Item item)
        {
            this.Itens.Add(item);
        }

        public double ItemDeMaiorValor(CarrinhoDeCompras carrinho)
        {
            double? valorItem = carrinho.Itens.OrderByDescending(i => i.ValorUnitario).FirstOrDefault()?.ValorUnitario;
            return valorItem.GetValueOrDefault();
        }
    }
}