using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.Highlights;
using Entity.Models.RealEstateManagement;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.Highlights;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateHighlightsService : BaseService<Highlights, HighlightsDto>, IRealEstateHighlightsService
    {
        public RealEstateHighlightsService(IRealEstateHighlightsRepository baseRepository, IMapper mapper) : base(baseRepository, mapper) { }
        [FluentValidationAspect(typeof(RealEstateHighlightsInsertionValiditor))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateHighlightsUpdateValidatior))]
        public override void Update(HighlightsDto dto)
        {
            base.Update(dto);
        }
    }
}
