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
    internal class UpdateAdresCommandHandler (IRepository<Address> _repository): IRequestHandler<UpdateAdresCommand>
    {
        public async Task Handle(UpdateAdresCommand request, CancellationToken cancellationToken)
        {
            var adres=await _repository.GetByIdAsync(request.Id);
            if (adres == null)
            {
                throw new Exception("Adres Bulunumadı");
            }
           request.Adapt(adres);
           await _repository.UpdateAsync(adres);

        }
    }
}
