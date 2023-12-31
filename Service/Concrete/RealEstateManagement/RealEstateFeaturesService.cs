﻿using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;
using Entity.Models.RealEstateManagement.RealEstateFeatures;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.EstateFeatures;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateFeaturesService : BaseService<RealEstateFeatures, RealEstateFeaturesDto>, IRealEstateFeaturesService
    {
        public RealEstateFeaturesService(IRealEstateFeaturesRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
        [FluentValidationAspect(typeof(RealEstateFeaturesValidator))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateFeaturesValidator))]
        public override void Update(RealEstateFeaturesDto dto)
        {
            base.Update(dto);
        }
    }
}
