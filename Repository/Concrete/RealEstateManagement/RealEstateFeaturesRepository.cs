using Entity.Models.RealEstateManagement;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
using System.Linq.Expressions;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateFeaturesRepository : RepositoryBase<RealEstateFeatures>, IRealEstateFeaturesRepository
    {
        private readonly RepositoryContext _context;
        public RealEstateFeaturesRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }
        public override IEnumerable<RealEstateFeatures>? GetList(bool trackChanges = false)
        {
            return _context.RealEstateFeatures.Include(r => r.ParentRealEstateFeatures).Include(r => r.SubRealEstateFeatures);
        }
        public override RealEstateFeatures? Get(Expression<Func<RealEstateFeatures, bool>> filter, bool trackChanges = false)
        {
            return _context.RealEstateFeatures.Where(filter).Include(r => r.ParentRealEstateFeatures).Include(r => r.SubRealEstateFeatures).FirstOrDefault();
        }
        public override RealEstateFeatures? GetWithId(int id, bool trackChanges = false)
        {
            return Get(r => r.Id == id, trackChanges);
        }
    }
}
