namespace Proyecto.Data
{
    using Microsoft.EntityFrameworkCore;
    using Proyecto.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignacion>()
                .HasKey(a => new { a.ProyectoId, a.EmpleadoId });
        }
    }

}
