using MediatR;
using SiteManagement.Domain.Entities.Contracts;

namespace SiteManagement.Application.Features.Commands.Bills.UpdateBill
{
    public class UpdateBillCommand : Bill, IRequest
    {
    }
}
