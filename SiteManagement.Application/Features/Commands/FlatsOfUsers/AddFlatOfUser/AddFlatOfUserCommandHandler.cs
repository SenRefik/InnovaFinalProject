using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Domain.Entities.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.AddFlatOfUser
{
    public class AddFlatOfUserCommandHandler : IRequestHandler<AddFlatOfUserCommand, int>
    {
        private readonly IFlatOfUserRepository _flatOfUserRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddFlatOfUserCommandHandler> _logger;

        public AddFlatOfUserCommandHandler(IFlatOfUserRepository flatOfUserRepository, IMapper mapper, ILogger<AddFlatOfUserCommandHandler> logger)
        {
            _flatOfUserRepository = flatOfUserRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(AddFlatOfUserCommand request, CancellationToken cancellationToken)
        {
            var flatOfUserEntity = _mapper.Map<FlatOfUser>(request);
            var newflatOfUser = await _flatOfUserRepository.AddAsync(flatOfUserEntity);
            _logger.LogInformation($"Flat Of User [Id : {newflatOfUser.Id} is successfully created.]");
            return newflatOfUser.Id;
        }
    }
}
