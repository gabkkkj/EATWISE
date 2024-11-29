using EatWise.Models;
using Microsoft.EntityFrameworkCore;

namespace EatWise.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nutricionista> Nutricionistas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("tbusuario");
            modelBuilder.Entity<Nutricionista>().ToTable("tbNutricionistas");
        }
    }
}
