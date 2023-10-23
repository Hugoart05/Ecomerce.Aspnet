using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUsuario : IRepositoryBase<Usuario>
    {
        Usuario SignIn(Login login);
        Task<bool> RecuperacaoDeSenha(string user, string password, string password2);
        
    }
}
