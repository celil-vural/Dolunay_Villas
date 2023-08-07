using Entity.Models;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;

namespace Repository.Concrete
{
    public class RealEstateItemTypesRepository : RepositoryBase<ItemTypes>, IRealEstateItemTypesRepository
    {
        public RealEstateItemTypesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
