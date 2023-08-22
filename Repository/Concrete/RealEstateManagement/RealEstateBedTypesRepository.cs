using Entity.Models.RealEstateManagement.BedTypes;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateBedTypesRepository : RepositoryBase<BedTypes>, IRealEstateBedTypesRepository
    {
        public RealEstateBedTypesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
