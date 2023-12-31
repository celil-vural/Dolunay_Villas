﻿using AutoMapper;
using Dolunay_Villas.Core.CrossCuttingConcerns.Aspects.Postsharp.ValidationAspect;
using Entity.Dtos.RealEstateManagement.Highlights;
using Entity.Models.RealEstateManagement.Highlights;
using Repository.Contracts.RealEstateManagement;
using Service.Contract.RealEstateManagement;
using Service.ValidationRules.FluentValidation.RealEstate.Highlights;

namespace Service.Concrete.RealEstateManagement
{
    public class RealEstateHighlightsService : BaseService<Highlight, HighlightsDto>, IRealEstateHighlightsService
    {
        public RealEstateHighlightsService(IRealEstateHighlightsRepository baseRepository, IMapper mapper) : base(baseRepository, mapper) { }
        [FluentValidationAspect(typeof(RealEstateHighlightsValiditor))]
        public override int CreateWithDto<TDtoForInsertion>(TDtoForInsertion dtoForInsertion)
        {
            return base.CreateWithDto(dtoForInsertion);
        }
        [FluentValidationAspect(typeof(RealEstateHighlightsValiditor))]
        public override void Update(HighlightsDto dto)
        {
            base.Update(dto);
        }
    }
}
