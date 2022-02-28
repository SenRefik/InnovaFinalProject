using MediatR;
using Microsoft.AspNetCore.Mvc;
using SiteManagement.Application.Features.Commands.Fees.AddFee;
using SiteManagement.Application.Features.Commands.Fees.DeleteFee;
using SiteManagement.Application.Features.Commands.Fees.UpdateFee;
using SiteManagement.Application.Features.Queries.Fees;
using System.Threading.Tasks;

namespace SiteManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetFeeListQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddFeeCommand addFee)
        {
            var result = await _mediator.Send(addFee);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody] DeleteFeeCommand deleteFee)
        {
            var result = await _mediator.Send(deleteFee);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFeeCommand updateFee)
        {
            var result = await _mediator.Send(updateFee);
            return Ok(result);
        }

    }
}
