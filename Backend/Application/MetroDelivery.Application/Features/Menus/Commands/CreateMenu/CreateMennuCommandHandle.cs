﻿using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Menus.Commands.CreateMenu
{
    public class CreateMennuCommandHandle : IRequestHandler<CreateMennuCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateMennuCommandHandle(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateMennuCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateMennuCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }
            var checkMenuExist = await _metroPickUpDbContext.Menu.Where(m => m.StartTimeService == request.StartTimeService && m.EndTimeService == request.EndTimeService && m.Priority == true).SingleOrDefaultAsync();
            if(checkMenuExist != null) {
                throw new NotFoundException("Menu này đã tạo rồi");
            }
            var menu = new Menu
            {
                StartTimeService = request.StartTimeService,
                EndTimeService = request.EndTimeService, 
                ApplyDate = request.ApplyDate,
                Priority = request.Priority,
            };

            _metroPickUpDbContext.Menu.Add(menu);
            await _metroPickUpDbContext.SaveChangesAsync();

            return menu.Id;
        }
    }
}
