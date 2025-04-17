using Microsoft.EntityFrameworkCore; // Para DbContext
using MyApi.Models; // Certifique-se de que este namespace está correto

namespace MyApi.Data // O namespace deve corresponder ao que você está usando
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; } // Defina a propriedade DbSet para Produtos
    }
}