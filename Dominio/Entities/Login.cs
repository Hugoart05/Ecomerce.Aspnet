using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Login
    {
        public string Email {  get; set; }
        
        public string Password { get; set; }
        public string Message {  get; set; }
    }
}
