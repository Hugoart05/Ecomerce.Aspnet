using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class ItemDeCarrinho
    {
        public int ItemDeCarrinhoId { get; set; }

        [ForeignKey("produtoId")]
        public int ProdutoId {  get; set; }
        public Produto Produto { get; set; }


        [ForeignKey("CarrinhoId")]
        public int CarrinhoId { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
