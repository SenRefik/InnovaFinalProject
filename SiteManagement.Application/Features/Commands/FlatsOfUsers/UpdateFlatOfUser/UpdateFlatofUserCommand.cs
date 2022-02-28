using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.UpdateFlatOfUser
{
    public class UpdateFlatOfUserCommand : FlatOfUser, IRequest
    {
    }
}
