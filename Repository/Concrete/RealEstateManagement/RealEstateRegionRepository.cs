using Entity.Models.RealEstateManagement.Region;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
using System.Linq.Expressions;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateRegionRepository : RepositoryBase<Region>, IRealEstateRegionRepository
    {
        private readonly RepositoryContext _context;
        public RealEstateRegionRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }
        public override IEnumerable<Region>? GetList(bool trackChanges = false)
        {
            return _context.Regions.Include(r => r.ParentRegion).Include(r => r.SubRegions).ToList();
        }
        public override Region? Get(Expression<Func<Region, bool>> filter, bool trackChanges = false)
        {
            return _context.Regions.Where(filter).Include(r => r.ParentRegion).Include(r => r.SubRegions).FirstOrDefault();
        }
        public override Region? GetWithId(int id, bool trackChanges = false)
        {
            return Get(r => r.Id == id, trackChanges);
        }
    }
}
