using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using SiteManagement.Application.Features.Commands.Bills.AddBill;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Bills.DeleteBill
{
    public class DeleteFeeCommandHandler : IRequestHandler<DeleteBillCommand>
    {
        private readonly IBillRepository _billRepository;
        private readonly ILogger<AddBillCommandHandler> _logger;

        public DeleteFeeCommandHandler(IBillRepository billRepository, ILogger<AddBillCommandHandler> logger)
        {
            _billRepository = billRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteBillCommand request, CancellationToken cancellationToken)
        {
            var billToDelete = await _billRepository.GetByIdAsync(request.Id);
            if (billToDelete == null)
                throw new NotFoundException("The bill have not found!");

            await _billRepository.RemoveAsync(billToDelete);
            _logger.LogInformation($"Bill {billToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}
