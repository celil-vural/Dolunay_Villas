using AutoMapper;
using Entity.Dtos.RealEstateManagement.Highlights;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateHighlightsService : BaseService<Highlights, HighlightsDto>, IRealEstateHighlightsService
    {
        public RealEstateHighlightsService(IRealEstateHighlightsRepository baseRepository, IMapper mapper) : base(baseRepository, mapper) { }

    }
}
