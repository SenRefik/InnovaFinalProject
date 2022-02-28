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

namespace SiteManagement.Application.Features.Queries.FlatsOfUsers
{
    public class GetFlatOfUserListQueryHandler : IRequestHandler<GetFlatOfUserListQuery, IReadOnlyList<FlatOfUser>>
    {
        private readonly IFlatOfUserRepository _flatOfUserRepository;

        public GetFlatOfUserListQueryHandler(IFlatOfUserRepository flatOfUserRepository)
        {
            _flatOfUserRepository = flatOfUserRepository;
        }

        public async Task<IReadOnlyList<FlatOfUser>> Handle(GetFlatOfUserListQuery request, CancellationToken cancellationToken)
        {
            var flatOfUsers = await _flatOfUserRepository.GetAllAsync();
            if (flatOfUsers == null)
                throw new NotFoundException(request);
            return flatOfUsers;
        }
    }
}
