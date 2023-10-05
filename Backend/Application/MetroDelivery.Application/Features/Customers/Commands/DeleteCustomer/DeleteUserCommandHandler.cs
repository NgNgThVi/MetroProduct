using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;

namespace MetroDelivery.Application.Features.Customers.Commands.DeleteCustomer
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        public DeleteUserCommandHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            // retrieve domain entity object
            var customerDelete = await _customerRepository.CustomerIdMusBeExist(request.Id);
            if (customerDelete == null) {
                throw new NotFoundException(nameof(customerDelete.ApplicationUser.Email), request.Id);
            }
            else if (customerDelete.IsDelete == true) {
                throw new NotFoundException("The customer have been deleted");
            }


            // rmove database
            await _customerRepository.DeleteAsync(customerDelete);

            // return
            return Unit.Value;
        }
    }
}
