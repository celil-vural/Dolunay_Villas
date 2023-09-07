using Entity.Models;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;

namespace Repository.Concrete
{
    public class VillaRepository : RepositoryBase<Villa>, IVillaRepository
    {
        public VillaRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
