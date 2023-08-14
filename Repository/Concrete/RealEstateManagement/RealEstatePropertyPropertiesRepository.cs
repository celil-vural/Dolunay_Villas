using Entity.Models.RealEstateManagement;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstatePropertyPropertiesRepository : RepositoryBase<PropertyProperties>, IRealEstatePropertyPropertiesRepository
    {
        public RealEstatePropertyPropertiesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
