using MediatR;
using SiteManagement.Application.Models.Fees;

namespace SiteManagement.Application.Features.Commands.Fees.AddFee
{
    public class AddFeeCommand : AddFeeDto, IRequest<int>
    {
    }
}
