using MediatR;
using SiteManagement.Application.Models.FlatsOfUsers;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.AddFlatOfUser
{
    public class AddFlatOfUserCommand : AddFlatOfUserDto, IRequest<int>
    {
    }
}
