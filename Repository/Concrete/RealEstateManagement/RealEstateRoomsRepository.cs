﻿using Entity.Models.RealEstateManagement.Room;
using Repository.Concrete.EntityFramework;
using Repository.Contracts.RealEstateManagement;

namespace Repository.Concrete.RealEstateManagement
{
    public class RealEstateRoomsRepository : RepositoryBase<Rooms>, IRealEstateRoomsRepository
    {
        public RealEstateRoomsRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
