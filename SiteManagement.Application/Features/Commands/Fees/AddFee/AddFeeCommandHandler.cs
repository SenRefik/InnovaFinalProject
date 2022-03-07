using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Domain.Entities.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Fees.AddFee
{
    public class AddFeeCommandHandler : IRequestHandler<AddFeeCommand, int>
    {
        private readonly IFeeRepository _FeeRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddFeeCommandHandler> _logger;

        public AddFeeCommandHandler(IFeeRepository FeeRepository, IMapper mapper, ILogger<AddFeeCommandHandler> logger)
        {
            _FeeRepository = FeeRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(AddFeeCommand request, CancellationToken cancellationToken)
        {
            var FeeEntity = _mapper.Map<Fee>(request);
            var newFee = await _FeeRepository.AddAsync(FeeEntity);
            _logger.LogInformation($"Fee [Id : {newFee.Id} is successfully created.]");
            return newFee.Id;
        }
    }
}
