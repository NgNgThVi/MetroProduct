using MediatR;
using MetroDelivery.Application.Features.Customers.Commands.CreateCustomer;
using MetroDelivery.Application.Features.Stations.Commands.UpdateStation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menus.Commands.CreateMenu
{
    public class CreateMennuCommand : IRequest<Guid>
    {
        public TimeSpan StartTimeService { get; set; }
        public TimeSpan EndTimeService { get; set; }
    }
}
