using Entity.Models.RealEstateManagement.Distance;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateDistancesRepository : RepositoryBase<Distances>, IRealEstateDistancesRepository
    {
        public RealEstateDistancesRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
