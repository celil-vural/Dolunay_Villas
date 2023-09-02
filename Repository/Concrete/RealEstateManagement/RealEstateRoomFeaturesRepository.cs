using Entity.Models.RealEstateManagement.RoomFeatures;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateRoomFeaturesRepository : RepositoryBase<RoomFeature>, IRealEstateRoomFeaturesRepository
    {
        public RealEstateRoomFeaturesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
