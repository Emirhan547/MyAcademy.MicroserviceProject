using ECommerce.Order.Application.Features.Addresses.Commands;
using ECommerce.Order.Application.Features.Addresses.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController (IMediator _mediator): ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult>GetAdreses()
        {
            var adresses = await _mediator.Send(new GetAdresesQuery());
            return Ok(adresses);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAdres(CreateAdresesCommand command)
        {
            await _mediator.Send(command);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdres(UpdateAdresCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
