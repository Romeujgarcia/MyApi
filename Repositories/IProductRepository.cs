using System.Collections.Generic; // Para IEnumerable<>
using System.Threading.Tasks; // Para Task<>
using MyApi.Models; // Para a classe Produto

namespace MyApi.Services // O namespace deve ser MyApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Produto>> GetAllProductsAsync();
        Task<Produto> GetProductByIdAsync(int id);
        Task AddProductAsync(Produto product);
        Task UpdateProductAsync(Produto product);
        Task DeleteProductAsync(int id);
    }
}