using Entity.Models.RealEstateManagement;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
using System.Linq.Expressions;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateDistanceRulerRepository : RepositoryBase<DistanceRuler>, IRealEstateDistanceRulerRepository
    {
        private readonly RepositoryContext _context;
        public RealEstateDistanceRulerRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }
        public override IEnumerable<DistanceRuler>? GetList(bool trackChanges = false)
        {
            return _context.DistanceRulers.Include(r => r.Distance).Include(r => r.LocationType).Include(r => r.Region);
        }
        public override DistanceRuler? Get(Expression<Func<DistanceRuler, bool>> filter, bool trackChanges = false)
        {
            return _context.DistanceRulers.Where(filter).Include(r => r.Distance).Include(r => r.LocationType).Include(r => r.Region).FirstOrDefault();
        }
        public override DistanceRuler? GetWithId(int id, bool trackChanges = false)
        {
            return Get(r => r.Id == id, trackChanges);
        }
    }
}
