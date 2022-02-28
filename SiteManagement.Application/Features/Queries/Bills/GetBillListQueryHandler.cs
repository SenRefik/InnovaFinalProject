using MediatR;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Queries.Bills
{
    public class GetBillListQueryHandler : IRequestHandler<GetBillListQuery, IReadOnlyList<Bill>>
    {
        private readonly IBillRepository _billRepository;

        public GetBillListQueryHandler(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public async Task<IReadOnlyList<Bill>> Handle(GetBillListQuery request, CancellationToken cancellationToken)
        {
            var bills = await _billRepository.GetAllAsync();
            if (bills == null)
                throw new NotFoundException(request);
            return bills;
        }
    }
}
