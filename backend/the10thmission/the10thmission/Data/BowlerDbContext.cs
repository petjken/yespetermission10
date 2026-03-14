using Microsoft.EntityFrameworkCore;

namespace the10thmission.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }

        public DbSet<BowlerInfo> Bowlers { get; set; }
    }
}
