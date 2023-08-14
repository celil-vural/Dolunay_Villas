using Entity.Models.RealEstateManagement;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateFeaturesRepository : RepositoryBase<RealEstateFeatures>, IRealEstateFeaturesRepository
    {
        public RealEstateFeaturesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
