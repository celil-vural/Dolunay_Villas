using AutoMapper;
using Entity.Dtos.Photo;
using Entity.Models;
using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class PhotoService : BaseService<Photo, PhotoDto>, IPhotoService
    {
        public PhotoService(IPhotoRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
