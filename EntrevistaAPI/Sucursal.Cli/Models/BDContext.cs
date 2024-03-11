using Microsoft.EntityFrameworkCore;

namespace Sucursal.Serv.Models
{
    public class BDContext : DbContext
    {

        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {
        }

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<SucursalDir> SucursalDir { get; set; }
    }
}
