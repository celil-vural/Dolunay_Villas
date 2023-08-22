using Entity.Models.RealEstateManagement.EstateType;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
using System.Linq.Expressions;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateTypesRepository : RepositoryBase<EstateTypes>, IRealEstateTypesRepository
    {
        private readonly RepositoryContext _context;
        public RealEstateTypesRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }
        public override IEnumerable<EstateTypes>? GetList(bool trackChanges = false)
        {
            return _context.EstateTypes.Include(r => r.ParentEstateTypes).Include(r => r.SubEstateTypes).Include(r => r.Photo);
        }
        public override EstateTypes? Get(Expression<Func<EstateTypes, bool>> filter, bool trackChanges = false)
        {
            return _context.EstateTypes.Where(filter).Include(r => r.ParentEstateTypes).Include(r => r.SubEstateTypes).FirstOrDefault();
        }
        public override EstateTypes? GetWithId(int id, bool trackChanges = false)
        {
            return Get(r => r.Id == id, trackChanges);
        }
    }
}
