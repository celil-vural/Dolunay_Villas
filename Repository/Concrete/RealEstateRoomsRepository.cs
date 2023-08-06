using Entity.Models;
using Entity.RequestParameters;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;
using Repository.Extensions;

namespace Repository.Concrete
{
    public class RealEstateRoomsRepository : RepositoryBase<Rooms>, IRealEstateRoomsRepository
    {
        public RealEstateRoomsRepository(RepositoryContext context) : base(context)
        {

        }

        public IEnumerable<Rooms>? GetAllWithDetails(PageRequestParameters? parameters)
        {
            if (parameters == null)
            {
                return GetList();
            }
            return GetList()?.ToList().ToPaginatedList(parameters.PageNumber, parameters.PageSize);
        }

        public Rooms? GetRoomsWithId(int id)
        {
            return Get((r) => r.Id == id);
        }
    }
}
