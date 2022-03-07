using MediatR;
using SiteManagement.Domain.Entities.Contracts;

namespace SiteManagement.Application.Features.Commands.Flats.UpdateFlat
{
    public class UpdateFlatCommand : Flat, IRequest
    {
    }
}
