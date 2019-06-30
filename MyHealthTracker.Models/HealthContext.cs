using Microsoft.EntityFrameworkCore;
using MyHealthTracker.Data;

namespace MyHealthTracker.Models
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {

        }

        public DbContext()
        {
        }

        public static DbContext Create()
        {
            return new DbContext();
        }

        public DbSet<HealthRecord> HealthRecords { get; set; }
    }
}
