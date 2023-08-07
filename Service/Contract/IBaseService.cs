using Entity.Contracts;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IBaseService<TEntity, TDto> where TEntity : class, IEntity, new() where TDto : new()
    {
        void CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion);
        void Delete(int id);
        void GetNotFoundExceptions(TEntity? entity);
        TDtoForUpdate? GetEntity<TDtoForUpdate>(int id);
        IEnumerable<TDto>? GetList();
        void Update(TDto dto);
        IEnumerable<TDto>? GetWithDetail(PageRequestParameters? parameters);
    }
}
