using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Domain.Entities.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Flats.AddFlat
{
    public class AddFlatCommandHandler : IRequestHandler<AddFlatCommand, int>
    {
        private readonly IFlatRepository _flatRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddFlatCommandHandler> _logger;

        public AddFlatCommandHandler(IFlatRepository flatRepository, IMapper mapper, ILogger<AddFlatCommandHandler> logger)
        {
            _flatRepository = flatRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(AddFlatCommand request, CancellationToken cancellationToken)
        {
            var flatEntity = _mapper.Map<Flat>(request);
            var newFlat = await _flatRepository.AddAsync(flatEntity);
            _logger.LogInformation($"Flat [Id : {newFlat.Id} is successfully created.]");
            return newFlat.Id;
        }
    }
}
