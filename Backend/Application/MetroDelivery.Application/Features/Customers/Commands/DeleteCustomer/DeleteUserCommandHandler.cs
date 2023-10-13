using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Customers.Commands.DeleteCustomer
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        /*private readonly ICustomerRepository _customerRepository;
        public DeleteUserCommandHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;*/
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public DeleteUserCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            // retrieve domain entity object
            /*var customerDelete = await _customerRepository.CustomerIdMusBeExist(request.Id);*/
            var customerDelete = await _metroPickUpDbContext.Customer.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
            if (customerDelete == null) {
                throw new NotFoundException(nameof(customerDelete.ApplicationUser.Email), request.Id);
            }
            else if (customerDelete.IsDelete == true) {
                throw new NotFoundException("The customer have been deleted");
            }


            // rmove database
           /* await _customerRepository.DeleteAsync(customerDelete);*/
            customerDelete.IsDelete = true;
            _metroPickUpDbContext.Customer.Update(customerDelete);
            await _metroPickUpDbContext.SaveChangesAsync();

            // return
            return Unit.Value;
        }
    }
}
