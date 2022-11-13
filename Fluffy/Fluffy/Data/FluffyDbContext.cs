using Fluffy.Models;
using Microsoft.EntityFrameworkCore;

namespace Fluffy.Data
{
    public class FluffyDbContext : DbContext
    {
        public FluffyDbContext()
        {

        }

        public FluffyDbContext(DbContextOptions<FluffyDbContext> options)
            :base(options)
        {

        }

        public DbSet<Cat> Cats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
