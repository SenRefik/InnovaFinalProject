using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System.Collections.Generic;

namespace SiteManagement.Application.Features.Queries.Fees
{
    public class GetFeeListQuery : IRequest<IReadOnlyList<Fee>>
    {
    }
}
