using Entity.Models.RealEstateManagement.Highlights;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateHighlightsRepository : RepositoryBase<Highlights>, IRealEstateHighlightsRepository
    {
        public RealEstateHighlightsRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
