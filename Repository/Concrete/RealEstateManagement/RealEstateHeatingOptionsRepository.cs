using Entity.Models.RealEstateManagement.HeatingOptions;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateHeatingOptionsRepository : RepositoryBase<HeatingOption>, IRealEstateHeatingOptionsRepository
    {
        public RealEstateHeatingOptionsRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
