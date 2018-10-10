using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestDrivenDevelopment;

namespace TestDrivenDevelopment.Tests
{
    [TestFixture]
    public class MaiorPrecoTest {

        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicializa()
        {
            carrinho = new CarrinhoDeCompras();
        }

        [TearDown]
        public void ExecutadoAposExecucaoDeTodosOsTestes()
        {
            carrinho = null;
        }

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            double valor = carrinho.MaiorValor(carrinho);
            Assert.AreEqual(0.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            double valor = carrinho.MaiorValor(carrinho);
            Assert.AreEqual(900.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoComNElementos()
        {
            carrinho = new CarrinhoDeComprasBuilder()
                        .ComItens(900.0, 1950.0, 950).Cria();

            double valor = carrinho.MaiorValor(carrinho);
            Assert.AreEqual(1950.0, valor, 0.0001);
        }

        [Test]
        public void DeveAdicionarItens()
        {
            Assert.AreEqual(0, carrinho.Itens.Count);

            Item item = new Item("item", 1, 100);
            carrinho.Adiciona(item);

            Assert.AreEqual(1, carrinho.Itens.Count);
            Assert.AreEqual(item, carrinho.Itens[0]);

        }

    }
}
