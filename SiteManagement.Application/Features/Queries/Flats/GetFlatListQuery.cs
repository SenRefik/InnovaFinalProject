using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System.Collections.Generic;

namespace SiteManagement.Application.Features.Queries.Flats
{
    public class GetFlatListQuery : IRequest<IReadOnlyList<Flat>>
    {
    }
}
