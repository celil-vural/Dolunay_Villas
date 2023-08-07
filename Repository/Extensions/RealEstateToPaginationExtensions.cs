namespace Repository.Extensions
{
    public static class RealEstateToPaginationExtensions
    {
        public static IEnumerable<TEntity> ToPaginatedList<TEntity>(this List<TEntity>? entity, int? pageNumber, int? pageSize)
        {
            pageNumber ??= 1;
            pageSize ??= 20;
            if (entity == null)
            {
                return new List<TEntity>();
            }
            return entity.Skip((int)((pageNumber - 1) * pageSize)).Take((int)pageSize).ToList();
        }
    }
}
