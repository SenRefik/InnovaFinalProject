using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Bills.UpdateBill
{
    public class UpdateBillCommandHandler : IRequestHandler<UpdateBillCommand>
    {
        private readonly IBillRepository _billRepository;
        private readonly ILogger<UpdateBillCommandHandler> _logger;

        public UpdateBillCommandHandler(IBillRepository billRepository, ILogger<UpdateBillCommandHandler> logger)
        {
            _billRepository = billRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateBillCommand request, CancellationToken cancellationToken)
        {
            var billToUpdate = await _billRepository.GetByIdAsync(request.Id);
            if (billToUpdate == null)
                throw new NotFoundException(nameof(Bills), request.Id);
            await _billRepository.UpdateAsync(request);
            return Unit.Value;
        }
    }
}
