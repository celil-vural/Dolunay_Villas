﻿using Entity.Dtos.RealEstateManagement.ValueTypes;
using ValueTypes = Entity.Models.RealEstateManagement.ValueType;
namespace Service.Contract.RealEstateManagement
{
    public interface IRealEstateValueTypesService : IBaseService<ValueTypes, ValueTypeDto> { }
}
