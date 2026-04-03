using Microsoft.EntityFrameworkCore;
using CrudUsuarios.Models;

namespace CrudUsuarios.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Representa la tabla Usuarios
        public DbSet<Usuario> Usuarios { get; set; }
    }
}