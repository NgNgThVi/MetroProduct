using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Users.Commands.UpdateUser;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        public DeleteUserCommandHandler(ICustomerRepository customerRepository) => this._customerRepository = customerRepository;

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            // retrieve domain entity object
            var customerDelete = await _customerRepository.CustomerIdMusBeExist(request.Id);
            if (customerDelete == null) {
                throw new NotFoundExcrption(nameof(customerDelete.ApplicationUser.Email), request.Id);
            }
            else if (customerDelete.IsDelete == true) {
                throw new NotFoundExcrption("The customer have been deleted");
            }


            // rmove database
            await _customerRepository.DeleteAsync(customerDelete);

            // return
            return Unit.Value;
        }
    }
}
