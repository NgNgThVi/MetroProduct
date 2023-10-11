using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contant;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, MetroPickUpResponse>
    {
        private IMetroPickUpDbContext _dbContext { get; set; }

        public CreateOrderCommandHandler(IMetroPickUpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MetroPickUpResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
