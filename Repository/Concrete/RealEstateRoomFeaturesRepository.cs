using Entity.Models;
using Entity.RequestParameters;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using Repository.Extensions;

namespace Repository.Concrete
{
    public class RealEstateRoomFeaturesRepository : RepositoryBase<RoomFeatures>, IRealEstateRoomFeaturesRepository
    {
        public RealEstateRoomFeaturesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public IEnumerable<RoomFeatures>? GetAllRoomFeaturesWithDetails(PageRequestParameters? parameters)
        {
            if (parameters == null)
            {
                return GetList();
            }
            return GetList()?.ToList().ToPaginatedList(parameters.PageNumber, parameters.PageSize);
        }

        public RoomFeatures? GetRoomFeatureWithId(int id)
        {
            return Get((r) => r.Id == id);
        }
    }
}
