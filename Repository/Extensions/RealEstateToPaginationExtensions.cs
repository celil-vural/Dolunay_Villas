using Entity.Models;

namespace Repository.Extensions
{
    public static class RealEstateToPaginationExtensions
    {
        public static IEnumerable<Rules> ToPaginatedList(this List<Rules>? entity, int? pageNumber, int? pageSize)
        {
            pageNumber ??= 1;
            pageSize ??= 20;
            if (entity == null)
            {
                return new List<Rules>();
            }
            return entity.Skip((int)((pageNumber - 1) * pageSize)).Take((int)pageSize).ToList();
        }
        public static IEnumerable<HeatingOptions> ToPaginatedList(this List<HeatingOptions>? entity, int? pageNumber, int? pageSize)
        {
            pageNumber ??= 1;
            pageSize ??= 20;
            if (entity == null)
            {
                return new List<HeatingOptions>();
            }
            return entity.Skip((int)((pageNumber - 1) * pageSize)).Take((int)pageSize).ToList();
        }
        public static IEnumerable<RoomFeatures> ToPaginatedList(this List<RoomFeatures>? entity, int? pageNumber, int? pageSize)
        {
            pageNumber ??= 1;
            pageSize ??= 20;
            if (entity == null)
            {
                return new List<RoomFeatures>();
            }
            return entity.Skip((int)((pageNumber - 1) * pageSize)).Take((int)pageSize).ToList();
        }
        public static IEnumerable<Rooms> ToPaginatedList(this List<Rooms>? entity, int? pageNumber, int? pageSize)
        {
            pageNumber ??= 1;
            pageSize ??= 20;
            if (entity == null)
            {
                return new List<Rooms>();
            }
            return entity.Skip((int)((pageNumber - 1) * pageSize)).Take((int)pageSize).ToList();
        }
    }
}
