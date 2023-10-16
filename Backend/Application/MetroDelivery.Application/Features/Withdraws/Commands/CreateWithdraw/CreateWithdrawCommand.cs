using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Withdraws.Commands.CreateWithdraw
{
    public class CreateWithdrawCommand : IRequest<Guid>
    {
        public Guid CustomerID { get; set; }
        public Guid PaymentMethodID { get; set; }
        public double? Balance { get; set; }
        public double? Deposit { get; set; }
        public DateTime? CreateTimeOfWithdraw { get; set; }
    }

    public class CreateWithdrawCommandHandler : IRequestHandler<CreateWithdrawCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateWithdrawCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateWithdrawCommand request, CancellationToken cancellationToken)
        {
            // validate

            // insert
            var withdraw = new WithDraw
            {
                CustomerID = request.CustomerID,
                PaymentMethodID = request.PaymentMethodID,
                Balance = request.Balance,
                Deposit = request.Deposit,
                CreateTimeOfWithdraw = request.CreateTimeOfWithdraw,
            };

            _metroPickUpDbContext.WithDraw.Add(withdraw);
            await _metroPickUpDbContext.SaveChangesAsync();

            return withdraw.Id;
        }
    }
}
