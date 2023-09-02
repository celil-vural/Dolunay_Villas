using Entity.Models.RealEstateManagement.BedTypes;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
using System.Linq.Expressions;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateBedTypesRepository : RepositoryBase<BedType>, IRealEstateBedTypesRepository
    {
        private readonly RepositoryContext _context;

        public RealEstateBedTypesRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }
        public override IEnumerable<BedType>? GetList(bool trackChanges = false)
        {
            return _context.BedTypes.Include(r => r.ItemType).Include(r => r.ValueType).ToList();
        }
        public override BedType? Get(Expression<Func<BedType, bool>> filter, bool trackChanges = false)
        {
            return _context.BedTypes.Where(filter).Include(r => r.ItemType).Include(r => r.ValueType).FirstOrDefault();
        }
        public override BedType? GetWithId(int id, bool trackChanges = false)
        {
            return Get(r => r.Id == id, trackChanges);
        }
    }
}
