using MediatR;

namespace MetroDelivery.Application.Features.Menus.Commands.CreateMenu
{
    public class CreateMennuCommand : IRequest<Guid>
    {
        public TimeSpan StartTimeService { get; set; }
        public TimeSpan EndTimeService { get; set; }
        
    }
}
