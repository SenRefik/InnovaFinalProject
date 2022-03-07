using MediatR;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.DeleteFlatOfUser
{
    public class DeleteFlatOfUserCommand : IRequest
    {
        public int Id { get; set; }
    }
}
