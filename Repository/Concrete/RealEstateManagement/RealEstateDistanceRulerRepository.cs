using Entity.Models.RealEstateManagement;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateDistanceRulerRepository : RepositoryBase<DistanceRuler>, IRealEstateDistanceRulerRepository
    {
        public RealEstateDistanceRulerRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
