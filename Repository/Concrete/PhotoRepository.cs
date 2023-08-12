using Entity.Models;
using Repository.Concrete.EntityFramework;
using Repository.Contracts;

namespace Repository.Concrete
{
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository
    {
        public PhotoRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
