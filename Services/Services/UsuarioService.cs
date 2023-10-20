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
    public class UsuarioService : RepositoryBase<Usuario>, IUsuario
    {
        public UsuarioService(ContextoDb contexto) : base(contexto)
        {
        }
    }
}
