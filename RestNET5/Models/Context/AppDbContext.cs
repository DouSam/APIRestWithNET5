using Microsoft.EntityFrameworkCore;

namespace RestNET5.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Person>().Property(b => b.Id).UseIdentityAlwaysColumn();

        public DbSet<Person> People { get; set; }
    }
}
