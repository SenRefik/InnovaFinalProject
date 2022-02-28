using MediatR;
using Microsoft.AspNetCore.Mvc;
using SiteManagement.Application.Features.Commands.Flats.AddFlat;
using SiteManagement.Application.Features.Commands.Flats.DeleteFlat;
using SiteManagement.Application.Features.Commands.Flats.UpdateFlat;
using SiteManagement.Application.Features.Queries.Flats;
using System.Threading.Tasks;

namespace SiteManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlatController : ControllerBase
    {        
        private readonly IMediator _mediator;

        public FlatController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetFlatListQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddFlatCommand addFlat)
        {
            var result = await _mediator.Send(addFlat);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody] DeleteFlatCommand deleteFlat)
        {
            var result = await _mediator.Send(deleteFlat);
            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFlatCommand updateFlat)
        {
            var result = await _mediator.Send(updateFlat);
            return Ok(result);
        }

    }
}
