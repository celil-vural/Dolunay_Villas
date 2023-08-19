using Entity.Models.RealEstateManagement;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateLocationTypeRepository : RepositoryBase<LocationType>, IRealEstateLocationTypeRepository
    {
        public RealEstateLocationTypeRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
