using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.PaymentMethods.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Withdraws.Queries.GetAllWithdraw
{
    public class GetListWithdrawQuery : IRequest<List<WithdrawResponse>>
    {
    }

    public class GetListWithdrawQueryHandler : IRequestHandler<GetListWithdrawQuery, List<WithdrawResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetListWithdrawQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<WithdrawResponse>> Handle(GetListWithdrawQuery request, CancellationToken cancellationToken)
        {
            var listWithdraw = await _metroPickUpDbContext.WithDraw.Where(w => !w.IsDelete)
                                                                .Join(
                                                                    _metroPickUpDbContext.Customer,
                                                                    withdraws => withdraws.CustomerID,
                                                                    customer => customer.Id,
                                                                    (withdraws, customer) => new
                                                                    {
                                                                        WithDraws = withdraws,
                                                                        Customers = customer 
                                                                    }
                                                                )
                                                                .Join(
                                                                    _metroPickUpDbContext.PaymentMethod,
                                                                    combined => combined.WithDraws.PaymentMethodID,
                                                                    payment => payment.Id,
                                                                    (combined, payment) => new WithdrawResponse
                                                                    {
                                                                        Id = combined.WithDraws.Id,
                                                                        Balance = combined.WithDraws.Balance,
                                                                        Deposit = combined.WithDraws.Deposit,
                                                                        CustomerID = combined.WithDraws.CustomerID,
                                                                        PaymentMethodID = combined.WithDraws.PaymentMethodID,
                                                                        CreateTimeOfWithdraw = combined.WithDraws.CreateTimeOfWithdraw,

                                                                        CustomerData = _mapper.Map<CustomerData>(combined.Customers),
                                                                        PaymentMethodData = _mapper.Map<PaymentMethodResponse>(payment)
                                                                    }
                                                                ).ToListAsync();

            return listWithdraw;
        }
    }
}
