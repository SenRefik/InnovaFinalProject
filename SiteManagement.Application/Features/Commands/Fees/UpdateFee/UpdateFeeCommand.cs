using MediatR;
using SiteManagement.Domain.Entities.Contracts;

namespace SiteManagement.Application.Features.Commands.Fees.UpdateFee
{
    public class UpdateFeeCommand : Fee, IRequest
    {
    }
}
