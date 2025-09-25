using BlazorShop.Api.Model;

namespace BlazorShop.Api.Repository
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetItens();
        Task<Product> GetItem(long id);

        Task<IEnumerable<Product>> GetItensPorCategoria(long id);
        Task<IEnumerable<Category>> GetCategorias();
    }
}
