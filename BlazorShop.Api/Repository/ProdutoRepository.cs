using BlazorShop.Api.Data;
using BlazorShop.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Repository
{
    public class ProdutoRepository : IProduct
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetItem(long id)
        {
            var product = await _context.Products.Include(c=>c.Category).SingleOrDefaultAsync(p=>p.Id == id);   
            return product;
        }

        public async Task<IEnumerable<Product>> GetItens()
        {
            var product = await _context.Products.Include(c => c.Category).ToListAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetItensPorCategoria(long id)
        {
            var product = await _context.Products.Include(c => c.Category).Where(c => c.CategoryId == id).ToListAsync();
            return product;
        }
     

         public async Task<IEnumerable<Category>> GetCategorias()
        {
            var category = await _context.Categories.ToListAsync();
            return category;
        }
    }
}
