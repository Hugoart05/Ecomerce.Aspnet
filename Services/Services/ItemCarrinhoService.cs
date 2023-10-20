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
    public class ItemCarrinhoService : RepositoryBase<ItemDeCarrinho>, IItemCarrinho
    {
        public ItemCarrinhoService(ContextoDb contexto) : base(contexto)
        {
        }
    }
}
