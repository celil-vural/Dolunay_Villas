using Entity.Contracts;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IBaseService<TEntity, TDto> where TEntity : class, IEntity, new() where TDto : new()
    {
        int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion) where TDtoForInsertion : TDto, new();
        void Delete(int id);
        void GetNotFoundExceptions(TEntity? entity);
        TDtoForUpdate? GetEntity<TDtoForUpdate>(int id) where TDtoForUpdate : TDto, new();
        IEnumerable<TDto>? GetList();
        void Update(TDto dto);
        IEnumerable<TDto>? GetWithDetail(PageRequestParameters? parameters);
        TDto? GetWithId(int id);
    }
}
