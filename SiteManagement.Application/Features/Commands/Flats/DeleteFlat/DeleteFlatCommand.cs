using MediatR;

namespace SiteManagement.Application.Features.Commands.Flats.DeleteFlat
{
    public class DeleteFlatCommand : IRequest
    {
        public int Id { get; set; }
    }
}
