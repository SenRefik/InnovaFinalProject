using MediatR;
using SiteManagement.Domain.Entities.Contracts;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.UpdateFlatOfUser
{
    public class UpdateFlatOfUserCommand : FlatOfUser, IRequest
    {
    }
}
