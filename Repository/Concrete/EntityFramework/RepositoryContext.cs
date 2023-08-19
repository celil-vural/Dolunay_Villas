using Entity.Models;
using Entity.Models.RealEstateManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Repository.Concrete.EntityFramework
{
    public class RepositoryContext : IdentityDbContext<IdentityUser>
    {
        #region DbSet
        public DbSet<Rules> Rules { get; set; }
        public DbSet<HeatingOptions> HeatingOptions { get; set; }
        public DbSet<RoomFeatures> RoomFeatures { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<ItemTypes> ItemTypes { get; set; }
        public DbSet<Entity.Models.RealEstateManagement.ValueType> ValueTypes { get; set; }
        public DbSet<BedTypes> BedTypes { get; set; }
        public DbSet<Highlights> Highlights { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<RealEstateFeatures> RealEstateFeatures { get; set; }
        public DbSet<EstateTypes> EstateTypes { get; set; }
        public DbSet<Distances> Distances { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
        public DbSet<DistanceRuler> DistanceRulers { get; set; }
        #endregion
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
