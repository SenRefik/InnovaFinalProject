using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Commons;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Feautres.Flats.Commands.AddFlat;
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
    public class FlatController : ControllerBase
    {
        private readonly ILogger<FlatController> _logger;
        private readonly IFlatRepository flatRepository;
        private readonly ApplicationContext _appContext;
        private readonly IMediator _mediator;


        public FlatController(ILogger<FlatController> logger, ApplicationContext appContext, IMediator mediator)
        {
            _logger = logger;
            _appContext = appContext;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Flat>> GetAll()
        {
            var value = _appContext.Set<Flat>();
            return await value.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddFlatCommand addFlat)
        {
            var result = await _mediator.Send(addFlat);
            return Ok(result);
        }


    }
}
