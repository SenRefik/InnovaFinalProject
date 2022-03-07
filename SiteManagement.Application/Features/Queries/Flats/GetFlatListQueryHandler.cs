using MediatR;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using SiteManagement.Domain.Entities.Contracts;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Queries.Flats
{
    public class GetFlatListQueryHandler : IRequestHandler<GetFlatListQuery, IReadOnlyList<Flat>>
    {
        private readonly IFlatRepository _flatRepository;

        public GetFlatListQueryHandler(IFlatRepository flatRepository)
        {
            _flatRepository = flatRepository;
        }

        public async Task<IReadOnlyList<Flat>> Handle(GetFlatListQuery request, CancellationToken cancellationToken)
        {
            var flats = await _flatRepository.GetAllAsync();
            if (flats == null)
                throw new NotFoundException(request);
            return flats;
        }
    }
}
