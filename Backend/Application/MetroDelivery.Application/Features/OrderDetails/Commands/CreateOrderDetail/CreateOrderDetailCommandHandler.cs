using AutoMapper;
using FluentValidation;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.OrderDetails.Commands.CreateOrderDetail
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateOrderDetailCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            var productExist = await _metroPickUpDbContext.Product.Where(p => p.Id == request.ProductID && !p.IsDelete).SingleOrDefaultAsync();
            if(productExist == null) {
                throw new NotFoundException("ProductId không tồn tại");
            }

            var orderExist = await _metroPickUpDbContext.Order.Where(p => p.Id == request.OrderID && !p.IsDelete).SingleOrDefaultAsync();
            if (orderExist == null) {
                throw new NotFoundException("OrderId không tồn tại");
            }

            var validator = new CreateOrderDetailCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }

            var orderDetail = new OrderDetail
            {
                ProductID = request.ProductID,
                OrderID = request.OrderID,
                
                Quanity = request.Quanity,
                Price = request.Price,
            };

            _metroPickUpDbContext.OrderDetail.Add(orderDetail);
            await _metroPickUpDbContext.SaveChangesAsync();
            return orderDetail.Id;
        }
    }
}
