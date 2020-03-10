using System.Collections.Generic;

namespace mvc1.Models
{
    public class ProdutoRepository : IRepository
    {

        private readonly Context _context;
        public ProdutoRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Produto> Produtos => _context.Produtos;
    }
}