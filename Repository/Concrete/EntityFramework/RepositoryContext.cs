using Entity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Repository.Concrete.EntityFramework
{
    public class RepositoryContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Rules> Rules { get; set; }
        public DbSet<HeatingOptions> HeatingOptions { get; set; }
        public DbSet<RoomFeatures> RoomFeatures { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.ApplyConfiguration(new ProductConfig());
            // modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
