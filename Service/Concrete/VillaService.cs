using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.Villas;
using Entity.Models;
using Repository.Contracts;
using Service.Contract;
using Service.ValidationRules.FluentValidation.Villa;

namespace Service.Concrete
{
    public class VillaService : BaseService<Villa, VillaDto>, IVillaService
    {
        public VillaService(IVillaRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
        [FluentValidationAspect(typeof(VillaValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(VillaValidator))]
        public override void Update(VillaDto dto)
        {
            base.Update(dto);
        }
    }
}
