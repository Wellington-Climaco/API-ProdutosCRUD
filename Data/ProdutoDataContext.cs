using Microsoft.EntityFrameworkCore;
using Project_EveryMind.Data.Mapping;
using Project_EveryMind.Models;

namespace Project_EveryMind.Data
{
    public class ProdutoDataContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Produto;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.ApplyConfiguration(new ProdutoMap());

        }

    }
    
}
