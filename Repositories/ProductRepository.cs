using Microsoft.EntityFrameworkCore; // Para DbContext e ToListAsync
using MyApi.Data; // Para MyDbContext
using MyApi.Models; // Para a classe Produto
using MyApi.Repositories; // Para a interface IProductRepository
using System.Collections.Generic; // Para IEnumerable<>
using System.Threading.Tasks; // Para Task<>

namespace MyApi.Repositories // O namespace deve ser MyApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext _context;

        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> GetAllAsync() => await _context.Produtos.ToListAsync();
        public async Task<Produto> GetByIdAsync(int id) => await _context.Produtos.FindAsync(id);
        public async Task AddAsync(Produto product) { await _context.Produtos.AddAsync(product); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Produto product) { _context.Produtos.Update(product); await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var product = await GetByIdAsync(id); if (product != null) { _context.Produtos.Remove(product); await _context.SaveChangesAsync(); } }
    }
}