using Entity.Contracts;

namespace Service.Contract
{
    public interface IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        void CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion);
        void Delete(int id);
        void GetNotFoundExceptions(TEntity? entity);
        TDtoForUpdate? GetEntity<TDtoForUpdate>(int id);
        IEnumerable<TDto>? GetList<TDto>();
        void Update<TDto>(TDto dto);
    }
}
