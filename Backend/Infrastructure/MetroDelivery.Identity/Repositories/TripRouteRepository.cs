﻿using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Identity.DbContexts;

namespace MetroDelivery.Identity.Repositories
{
    public class TripRouteRepository : GenericRepository<Trip_Route>, ITripRouteRepository
    {
        public TripRouteRepository(MetroPickupIdentityDbContext context) : base(context)
        {
        }
    }
}
