using DAL.Repositories;
using DAL.Interfaces;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;

namespace Services.Services
{
    public class CarrinhoService : RepositoryBase<Carrinho>, ICarrinho
    {
        public CarrinhoService(ContextoDb contexto) : base(contexto)
        {
        }
    }
}
