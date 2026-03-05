using ECommerce.Order.Application.Features.Addresses.Commands;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Addresses.Handlers
{
    internal class CreateAdresesCommandHandler (IRepository<Address> _repository): IRequestHandler<CreateAdresesCommand>
    {
        public async Task Handle(CreateAdresesCommand request, CancellationToken cancellationToken)
        {
            var address = request.Adapt<Address>();
            await _repository.CreateAsync(address);
        }
    }
}
