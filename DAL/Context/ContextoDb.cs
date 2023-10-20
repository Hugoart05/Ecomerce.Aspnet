using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ContextoDb : DbContext
    {
        public ContextoDb(DbContextOptions<ContextoDb> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<ItemDeCarrinho> Items { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
