using MediatR;
using Microsoft.AspNetCore.Mvc;
using SiteManagement.Application.Features.Commands.Bills.AddBill;
using SiteManagement.Application.Features.Commands.Bills.DeleteBill;
using SiteManagement.Application.Features.Commands.Bills.UpdateBill;
using SiteManagement.Application.Features.Queries.Bills;
using System.Threading.Tasks;

namespace SiteManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BillController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetBillListQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddBillCommand addBill)
        {
            var result = await _mediator.Send(addBill);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody] DeleteBillCommand deleteBill)
        {
            var result = await _mediator.Send(deleteBill);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBillCommand updateBill)
        {
            var result = await _mediator.Send(updateBill);
            return Ok(result);
        }


    }
}
