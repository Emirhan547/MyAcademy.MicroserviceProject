using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Addresses.Commands
{
    public record UpdateAdresCommand(int Id, string UserId, string FirstName, string LastName, string City, string District, string AdressLine):IRequest
    {
    }
}
