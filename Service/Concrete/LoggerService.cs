using AutoMapper;
using Entity.Dtos.Log;
using Entity.Models;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class LoggerService : BaseService<Log, LogDto>, ILoggerService
    {
        public LoggerService(ILoggerRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
