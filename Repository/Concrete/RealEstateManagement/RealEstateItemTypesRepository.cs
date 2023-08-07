using Entity.Models.RealEstateManagement;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateItemTypesRepository : RepositoryBase<ItemTypes>, IRealEstateItemTypesRepository
    {
        public RealEstateItemTypesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
