using Entity.Models;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;

namespace Repository.Concrete
{
    public class LoggerRepository : RepositoryBase<Log>, ILoggerRepository
    {
        public LoggerRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
