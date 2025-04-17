using MyApi.Models; // Para a classe Produto
using MyApi.Repositories; // Para a interface IProductRepository
using System.Collections.Generic; // Para IEnumerable<>
using System.Threading.Tasks; // Para Task<>

namespace MyApi.Services // O namespace deve ser MyApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Produto>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Produto> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task AddProductAsync(Produto product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Produto product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}