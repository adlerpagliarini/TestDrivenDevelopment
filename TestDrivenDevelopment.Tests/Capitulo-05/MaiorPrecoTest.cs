using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestDrivenDevelopment;

namespace TestDrivenDevelopment.Tests
{
    [TestFixture]
    public class MaiorPrecoTest {

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            double valor = carrinho.ItemDeMaiorValor(carrinho);
            Assert.AreEqual(0.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            double valor = carrinho.ItemDeMaiorValor(carrinho);
            Assert.AreEqual(900.0, valor, 0.0001);
        }
        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoComNElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Notebook", 3, 1950.0));
            carrinho.Adiciona(new Item("Fogão", 2, 950.0));
            double valor = carrinho.ItemDeMaiorValor(carrinho);
            Assert.AreEqual(1950.0, valor, 0.0001);
        }

    }
}
