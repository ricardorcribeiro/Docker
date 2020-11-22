using System.Collections.Generic;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {

        public IEnumerable<Produto> Produtos => new Produto[]{
            new Produto{ProdutoId = 10, Nome = "caneta",Categoria ="material",Preco =20},
            new Produto{ProdutoId = 20, Nome = "borracha",Categoria ="material",Preco =5},
            new Produto{ProdutoId = 30, Nome = "mochila",Categoria ="material",Preco =100}
        };
    }
}