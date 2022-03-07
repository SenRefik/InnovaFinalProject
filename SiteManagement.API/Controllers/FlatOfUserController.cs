using MediatR;
using Microsoft.AspNetCore.Mvc;
using SiteManagement.Application.Features.Queries.FlatsOfUsers;
using SiteManagement.Application.Features.Commands.FlatsOfUsers.AddFlatOfUser;
using SiteManagement.Application.Features.Commands.FlatsOfUsers.DeleteFlatOfUser;
using SiteManagement.Application.Features.Commands.FlatsOfUsers.UpdateFlatOfUser;
using System.Threading.Tasks;

namespace SiteManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlatOfUserController : ControllerBase
    {   
        private readonly IMediator _mediator;

        public FlatOfUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetFlatOfUserListQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddFlatOfUserCommand addFlatOfUser)
        {
            var result = await _mediator.Send(addFlatOfUser);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody] DeleteFlatOfUserCommand deleteFlatOfUser)
        {
            var result = await _mediator.Send(deleteFlatOfUser);
            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFlatOfUserCommand updateFlatOfUser)
        {
            var result = await _mediator.Send(updateFlatOfUser);
            return Ok(result);
        }
    }
}
