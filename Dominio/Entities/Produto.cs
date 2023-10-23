using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Produto
    {
        
        public int ProdutoId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Quantidade{ get; set; }
        public int Preco { get; set; }

        
        public ICollection<Carrinho> Carrinhos { get; set; }
    }
}
