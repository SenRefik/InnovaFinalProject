using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Features.Commands.Bills.AddBill;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Bills.DeleteBill
{
    public class DeleteFeeCommandHandler : IRequestHandler<DeleteBillCommand>
    {
        private readonly IBillRepository _billRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddBillCommandHandler> _logger;

        public DeleteFeeCommandHandler(IBillRepository billRepository, IMapper mapper, ILogger<AddBillCommandHandler> logger)
        {
            _billRepository = billRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteBillCommand request, CancellationToken cancellationToken)
        {
            var billToDelete = await _billRepository.GetByIdAsync(request.Id);
            if (billToDelete == null)
                throw new ArgumentException();

            await _billRepository.RemoveAsync(billToDelete);
            _logger.LogInformation($"Bill {billToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}
