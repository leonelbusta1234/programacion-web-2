using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoWeb.Models;

namespace ProyectoWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Almacen> Almacen { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Slider> Slider { get; set; }

        public DbSet<Oficina> Oficina { get; set; }
    }
}
