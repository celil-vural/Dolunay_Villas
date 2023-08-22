using Entity.Models;
using Entity.Models.RealEstateManagement.BedTypes;
using Entity.Models.RealEstateManagement.Distance;
using Entity.Models.RealEstateManagement.DistanceRuler;
using Entity.Models.RealEstateManagement.EstateType;
using Entity.Models.RealEstateManagement.HeatingOption;
using Entity.Models.RealEstateManagement.Highlights;
using Entity.Models.RealEstateManagement.ItemType;
using Entity.Models.RealEstateManagement.LocationType;
using Entity.Models.RealEstateManagement.RealEstate;
using Entity.Models.RealEstateManagement.RealEstateFeatures;
using Entity.Models.RealEstateManagement.Region;
using Entity.Models.RealEstateManagement.ReservationTracking;
using Entity.Models.RealEstateManagement.Room;
using Entity.Models.RealEstateManagement.RoomDetails;
using Entity.Models.RealEstateManagement.RoomFeature;
using Entity.Models.RealEstateManagement.Rule;
using Entity.Models.Reservation;
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
        public DbSet<Entity.Models.RealEstateManagement.ValueType.ValueType> ValueTypes { get; set; }
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
        public DbSet<ReservationTrackingArea> ReservationTrackingAreas { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<ReservationTrackingForVilla> ReservationTrackingForVillas { get; set; }
        public DbSet<RoomDetails> RoomDetails { get; set; }
        #endregion
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
