using DesafioApiCardapio.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioApiCardapio.Context
{
    public class DbCardapioContext : DbContext
    {
        public DbCardapioContext(DbContextOptions<DbCardapioContext> options) : base(options)
        {

        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
