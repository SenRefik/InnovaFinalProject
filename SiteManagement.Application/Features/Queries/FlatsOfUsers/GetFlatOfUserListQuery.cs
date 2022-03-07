using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System.Collections.Generic;

namespace SiteManagement.Application.Features.Queries.FlatsOfUsers
{
    public class GetFlatOfUserListQuery : IRequest<IReadOnlyList<FlatOfUser>>
    {
    }
}
