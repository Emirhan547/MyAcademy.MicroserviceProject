using ECommerce.Order.Application.Features.Addresses.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Addresses.Queries
{
    public class GetAdresesQuery:IRequest<List<GetAdresesQueryResult>>
    {
    }
}
