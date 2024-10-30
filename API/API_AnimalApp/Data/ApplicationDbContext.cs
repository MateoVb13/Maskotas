using Microsoft.EntityFrameworkCore;
using API_AnimalApp.Models;

namespace API_AnimalApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define las tablas de la base de datos como DbSet<T>
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cita> Citas { get; set; }

        // Método opcional para configurar detalles específicos de las entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración adicional (opcional) para las tablas
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Cita>().ToTable("Citas");
        }
    }
}
