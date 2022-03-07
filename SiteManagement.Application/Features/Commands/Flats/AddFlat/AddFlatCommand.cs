using MediatR;
using SiteManagement.Application.Models.Flats;

namespace SiteManagement.Application.Features.Commands.Flats.AddFlat
{
    public class AddFlatCommand : AddFlatDto, IRequest<int>
    {
    }
}
