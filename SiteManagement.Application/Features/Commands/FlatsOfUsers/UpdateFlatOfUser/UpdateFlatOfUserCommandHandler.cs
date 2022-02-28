using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.UpdateFlatOfUser
{
    public class UpdateFlatCommandHandler : IRequestHandler<UpdateFlatOfUserCommand>
    {
        private readonly IFlatOfUserRepository _flatOfUserRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateFlatCommandHandler> _logger;

        public UpdateFlatCommandHandler(IFlatOfUserRepository flatOfUserRepository, IMapper mapper, ILogger<UpdateFlatCommandHandler> logger)
        {
            _flatOfUserRepository = flatOfUserRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateFlatOfUserCommand request, CancellationToken cancellationToken)
        {
            var flatOfUserToUpdate = await _flatOfUserRepository.GetByIdAsync(request.Id);
            if (flatOfUserToUpdate == null)
                throw new NotFoundException(nameof(FlatOfUser), request.Id);
            await _flatOfUserRepository.UpdateAsync(request);
            return Unit.Value;
        }
    }
}
