using Microsoft.EntityFrameworkCore;
using ProjetoCyberpunkRPG.Models;

namespace ProjetoCyberpunkRPG.Data
{
    public class CyberpunkContext : DbContext
    {
        public DbSet<Personagem> Personagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cyberpunk.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>()
                .OwnsOne(p => p.Atributos);

            modelBuilder.Entity<Personagem>()
                .Ignore(p => p.Classe);
        }
    }
}