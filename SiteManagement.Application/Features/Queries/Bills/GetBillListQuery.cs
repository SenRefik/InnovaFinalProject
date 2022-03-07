using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System.Collections.Generic;

namespace SiteManagement.Application.Features.Queries.Bills
{
    public class GetBillListQuery : IRequest<IReadOnlyList<Bill>>
    {
    }
}
