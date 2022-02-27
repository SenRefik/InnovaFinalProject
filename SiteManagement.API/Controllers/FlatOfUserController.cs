using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Commons;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Feautres.Commands.FlatsOfUsers.AddFlatOfUser;
using SiteManagement.Domain.Entities.Contracts;
using SiteManagement.Infrastructure.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlatOfUserController : ControllerBase
    {
        private readonly ILogger<FlatOfUserController> _logger;
        private readonly IFlatOfUserRepository FlatOfUserRepository;
        private readonly ApplicationContext _appContext;
        private readonly IMediator _mediator;


        public FlatOfUserController(ILogger<FlatOfUserController> logger, ApplicationContext appContext, IMediator mediator)
        {
            _logger = logger;
            _appContext = appContext;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<FlatOfUser>> GetAll()
        {
            var value = _appContext.Set<FlatOfUser>();
            return await value.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddFlatOfUserCommand addFlatOfUser)
        {
            var result = await _mediator.Send(addFlatOfUser);
            return Ok(result);
        }


    }
}
