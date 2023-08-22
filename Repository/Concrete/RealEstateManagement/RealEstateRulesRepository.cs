using Entity.Models.RealEstateManagement.Rule;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;
namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateRulesRepository : RepositoryBase<Rules>, IRealEstateRulesRepository
    {
        public RealEstateRulesRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
