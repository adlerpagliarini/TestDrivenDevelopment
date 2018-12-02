using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDrivenDevelopment.Capitulo._10.Entities;

namespace TestDrivenDevelopment.Capitulo._10.DAO
{
    public class ProdutoDAO
    {
        private DbContext dbContext;

        public ProdutoDAO(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Adiciona(Produto produto)
        {
            dbContext.Add(produto);
            dbContext.SaveChanges();
        }

        public Produto RetornoPorId(int id)
        {
            return dbContext.Set<Produto>().Find(id);
        }

        public IEnumerable<Produto> RetornaAtivos()
        {
            return dbContext.Set<Produto>().Where(p => p.Ativo);
        }
    }
}
