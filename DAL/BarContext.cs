using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> options)
            : base(options)
        {

        }

        public DbSet<Cerveza> Cervezas { get; set; }
        public DbSet<Marca> Marcas { get; set; }

    }
}