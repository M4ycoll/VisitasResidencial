using Microsoft.EntityFrameworkCore;
using Visitas_residencial.Models;

namespace Visitas_residencial.Data
{
    public class YourDbContext : DbContext
    {
        public DbSet<Casa> Casas { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<HabitantesCasa> HabitantesCasas { get; set; }

        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {
            Casas = Set<Casa>();
            Visitas = Set<Visita>();
            HabitantesCasas = Set<HabitantesCasa>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales del modelo si es necesario
        }
    }
}