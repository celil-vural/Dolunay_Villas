using Entity.Models.RealEstateManagement.HeatingOption;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateHeatingOptionsRepository : RepositoryBase<HeatingOptions>, IRealEstateHeatingOptionsRepository
    {
        public RealEstateHeatingOptionsRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
