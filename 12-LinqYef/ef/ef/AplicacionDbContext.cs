using Microsoft.EntityFrameworkCore;

namespace ef
{
    public class AplicacionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SM-NFEDIUKR7\\SQLEXPRESS;Database=CursoLinq;Trusted_Connection=True");
        }

        public DbSet<Persona> personas { get; set; }
    }
}
