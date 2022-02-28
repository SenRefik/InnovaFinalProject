using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Models.Bills;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Bills.AddBill
{
    public class AddBillCommandHandler : IRequestHandler<AddBillCommand, int>
    {
        private readonly IBillRepository _billRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddBillCommandHandler> _logger;

        public AddBillCommandHandler(IBillRepository billRepository, IMapper mapper, ILogger<AddBillCommandHandler> logger)
        {
            _billRepository = billRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(AddBillCommand request, CancellationToken cancellationToken)
        {
            var billEntity = _mapper.Map<Bill>(request);
            var newBill = await _billRepository.AddAsync(billEntity);
            _logger.LogInformation($"Bill [Id : {newBill.Id} is successfully created.]");
            return newBill.Id;
        }
    }
}
