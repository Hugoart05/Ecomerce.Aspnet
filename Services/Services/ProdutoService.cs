using DAL.Context;
using DAL.Interfaces;
using DAL.Repositories;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProdutoService : RepositoryBase<Produto>, IProduto
    {
        public ProdutoService(ContextoDb contexto) : base(contexto)
        {
        }
    }
}
