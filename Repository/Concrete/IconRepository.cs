using Entity.Models;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;

namespace Repository.Concrete
{
    public class IconRepository : RepositoryBase<Icon>, IIconRepository
    {
        public IconRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
