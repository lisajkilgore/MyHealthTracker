using Microsoft.EntityFrameworkCore;
using MyHealthTracker.Data;

namespace MyHealthTracker.Models
{
    public class HealthContext : DbContext
    {
        public HealthContext(DbContextOptions<HealthContext> options)
            : base(options)
        {

        }
        public DbSet<Health> HealthItems { get; set; }
    }
}
