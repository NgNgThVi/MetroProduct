using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contant;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Products.Commands.CreateProducts;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateOrderCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateOrderCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }

            var order = new Order
            {
                TotalPrice = request.TotalPrice,
                OrderTokenQR = request.OrderTokenQR,

                CustomerID = request.CustomerId,
                TripID = request.TripId,
                StoreID = request.StoreId
            };

            _metroPickUpDbContext.Order.Add(order);
            await _metroPickUpDbContext.SaveChangesAsync();

            return order.Id;
        }
    }
}
