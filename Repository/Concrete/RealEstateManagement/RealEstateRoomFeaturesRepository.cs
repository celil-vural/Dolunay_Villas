using Entity.Models.RealEstateManagement;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateRoomFeaturesRepository : RepositoryBase<RoomFeatures>, IRealEstateRoomFeaturesRepository
    {
        public RealEstateRoomFeaturesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
