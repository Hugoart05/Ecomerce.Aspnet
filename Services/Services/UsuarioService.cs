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
        private readonly ContextoDb _context;
        public UsuarioService(ContextoDb contexto, ContextoDb context) : base(contexto)
        {
            _context = context;
        }

        public Task<bool> RecuperacaoDeSenha(string user, string password, string password2)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(Login login)
        {
            var serachUser = _context.Usuarios.FirstOrDefault(x => x.Email == login.Email);
            if (serachUser == null)
            {

                throw new Exception();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
