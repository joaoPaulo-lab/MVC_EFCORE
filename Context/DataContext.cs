using Microsoft.EntityFrameworkCore;
using MVC_EFCORE.Mappings;
using MVC_EFCORE.Models;

namespace MVC_EFCORE.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(){ }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
        }
    }
}
