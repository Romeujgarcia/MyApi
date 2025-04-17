using System.Collections.Generic; // Para IEnumerable<>
using System.Threading.Tasks; // Para Task<>
using MyApi.Models; // Para a classe Produto

namespace MyApi.Repositories // O namespace deve ser MyApi.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Produto>> GetAllAsync();
        Task<Produto> GetByIdAsync(int id);
        Task AddAsync(Produto product);
        Task UpdateAsync(Produto product);
        Task DeleteAsync(int id);
    }
}