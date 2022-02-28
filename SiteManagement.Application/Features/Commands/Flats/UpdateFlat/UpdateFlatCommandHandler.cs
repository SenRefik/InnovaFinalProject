using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using SiteManagement.Application.Models.Flats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Flats.UpdateFlat
{
    public class UpdateFlatCommandHandler : IRequestHandler<UpdateFlatCommand>
    {
        private readonly IFlatRepository _flatRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateFlatCommandHandler> _logger;

        public UpdateFlatCommandHandler(IFlatRepository flatRepository, IMapper mapper, ILogger<UpdateFlatCommandHandler> logger)
        {
            _flatRepository = flatRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateFlatCommand request, CancellationToken cancellationToken)
        {
            var flatToUpdate = await _flatRepository.GetByIdAsync(request.Id);
            if (flatToUpdate == null)
                throw new NotFoundException(nameof(Flats), request.Id);
            await _flatRepository.UpdateAsync(request);
            return Unit.Value;
        }
    }
}
