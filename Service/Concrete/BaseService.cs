using AutoMapper;
using Entity.Contracts;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IRepositoryBase<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        protected BaseService(IRepositoryBase<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public void CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            TEntity entity = _mapper.Map<TEntity>(dtoForInsertion);
            _baseRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _baseRepository.Get((r) => r.Id == id);
            GetNotFoundExceptions(entity);
            _baseRepository.Delete(entity!);
        }

        public IEnumerable<TDto>? GetList<TDto>()
        {
            var entities = _baseRepository.GetList();
            var dto = _mapper.Map<IEnumerable<TDto>>(entities);
            return dto;
        }

        public void GetNotFoundExceptions(TEntity? entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
        }

        public TDtoForUpdate? GetEntity<TDtoForUpdate>(int id)
        {
            var entity = _baseRepository.Get((r) => r.Id == id);
            var dto = _mapper.Map<TDtoForUpdate>(entity);
            return dto;
        }
        public void Update<TDto>(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            GetNotFoundExceptions(entity);
            _baseRepository.Update(entity);
        }
    }
}
