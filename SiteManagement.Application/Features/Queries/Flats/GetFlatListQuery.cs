using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Queries.Flats
{
    public class GetFlatListQuery : IRequest<IReadOnlyList<Flat>>
    {
    }
}
