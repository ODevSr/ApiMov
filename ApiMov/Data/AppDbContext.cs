using Microsoft.EntityFrameworkCore;

namespace ApiMov.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Models.Mov> Mov { get; set; }
    }
}
