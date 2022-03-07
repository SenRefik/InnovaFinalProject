using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Fees.DeleteFee
{
    public class DeleteFeeCommandHandler : IRequestHandler<DeleteFeeCommand>
    {
        private readonly IFeeRepository _FeeRepository;
        private readonly ILogger<DeleteFeeCommandHandler> _logger;

        public DeleteFeeCommandHandler(IFeeRepository FeeRepository, ILogger<DeleteFeeCommandHandler> logger)
        {
            _FeeRepository = FeeRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteFeeCommand request, CancellationToken cancellationToken)
        {
            var FeeToDelete = await _FeeRepository.GetByIdAsync(request.Id);
            if (FeeToDelete == null)
                throw new NotFoundException("Not Found!");

            await _FeeRepository.RemoveAsync(FeeToDelete);
            _logger.LogInformation($"Fee {FeeToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}
