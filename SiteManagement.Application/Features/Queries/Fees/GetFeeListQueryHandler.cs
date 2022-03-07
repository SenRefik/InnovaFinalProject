using MediatR;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using SiteManagement.Domain.Entities.Contracts;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Queries.Fees
{
    public class GetFeeListQueryHandler : IRequestHandler<GetFeeListQuery, IReadOnlyList<Fee>>
    {
        private readonly IFeeRepository _feeRepository;

        public GetFeeListQueryHandler(IFeeRepository feeRepository)
        {
            _feeRepository = feeRepository;
        }

        public async Task<IReadOnlyList<Fee>> Handle(GetFeeListQuery request, CancellationToken cancellationToken)
        {
            var fees = await _feeRepository.GetAllAsync();
            if (fees == null)
                throw new NotFoundException(request);
            return fees;
        }
    }
}
