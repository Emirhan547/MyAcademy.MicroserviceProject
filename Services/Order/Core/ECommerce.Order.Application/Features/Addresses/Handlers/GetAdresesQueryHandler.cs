using ECommerce.Order.Application.Features.Addresses.Queries;
using ECommerce.Order.Application.Features.Addresses.Results;
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
    internal class GetAdresesQueryHandler (IRepository<Address> _repository): IRequestHandler<GetAdresesQuery, List<GetAdresesQueryResult>>
    {
        public async Task<List<GetAdresesQueryResult>> Handle(GetAdresesQuery request, CancellationToken cancellationToken)
        {
            var adresses = await _repository.GetAllAsync();
            return adresses.Adapt<List<GetAdresesQueryResult>>();
        }
    }
}
