using ListaNet.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaNet.Data
{
    public class OpticalContext : DbContext
    {
        public OpticalContext(DbContextOptions<OpticalContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Servico>().ToTable("Servico");
        }
    }
}
 