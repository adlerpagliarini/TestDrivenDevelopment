using Microsoft.EntityFrameworkCore.Storage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDrivenDevelopment.Capitulo._10.Context;
using TestDrivenDevelopment.Capitulo._10.DAO;
using TestDrivenDevelopment.Capitulo._10.Entities;

namespace TestDrivenDevelopment.Tests.Capitulo_10
{
    [TestFixture]
    public class ProdutoDAOTest
    {
        private DatabaseContext dbContext;
        private IDbContextTransaction transaction;

        [SetUp]
        public void Inicializa()
        {
            dbContext = new DatabaseContext();
            transaction = dbContext.Database.BeginTransaction();
        }

        [TearDown]
        public void ExecutadoAposExecucaoDeTodosOsTestes()
        {
            transaction.Rollback();
            dbContext.Dispose();
        }

        [Test]
        public void DeveAdicionarUmProduto()
        {
            var produtoDAO = new ProdutoDAO(dbContext);
            var produto = new Produto() { Nome = "Notebook" };

            produtoDAO.Adiciona(produto);
            var produtoAdicionado = produtoDAO.RetornoPorId(produto.Id);

            Assert.AreEqual(produtoAdicionado, produto);
        }

        [Test]
        public void DeveRetornarSomenteProdutosAtivos()
        {
            var produtoDAO = new ProdutoDAO(dbContext);
            var produto = new Produto() { Nome = "Notebook" };
            var inativo = new Produto() { Nome = "Notebook" };
            inativo.Inativa();

            produtoDAO.Adiciona(produto);
            produtoDAO.Adiciona(inativo);

            var produtosAdicionados = produtoDAO.RetornaAtivos();

            Assert.AreEqual(1, produtosAdicionados.Count());
            Assert.AreEqual(produto, produtosAdicionados.First());
        }
    }
}
