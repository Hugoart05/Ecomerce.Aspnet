using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Carrinho
    {
        public int CarrinhoId { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("usuarioId")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        public ICollection<ItemDeCarrinho> Items { get; set; }
    }
}
