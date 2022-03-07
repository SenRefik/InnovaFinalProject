using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Fees.UpdateFee
{
    public class UpdateFeeCommandHandler : IRequestHandler<UpdateFeeCommand>
    {
        private readonly IFeeRepository _feeRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateFeeCommandHandler> _logger;

        public UpdateFeeCommandHandler(IFeeRepository feeRepository, IMapper mapper, ILogger<UpdateFeeCommandHandler> logger)
        {
            _feeRepository = feeRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateFeeCommand request, CancellationToken cancellationToken)
        {
            var feeToUpdate = await _feeRepository.GetByIdAsync(request.Id);
            if (feeToUpdate == null)
                throw new NotFoundException(nameof(Fees), request.Id);
            await _feeRepository.UpdateAsync(request);
            return Unit.Value;
        }
    }
}
