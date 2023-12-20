using EjEfCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EjEfCore.DataAccess
{
    public class AcademiaDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public AcademiaDbContext() => this.Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OJOJIE1\SQLEXPRESS;Initial Catalog=AcademiaDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
