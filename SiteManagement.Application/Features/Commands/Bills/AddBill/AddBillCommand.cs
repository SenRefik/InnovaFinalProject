using MediatR;
using SiteManagement.Application.Models.Bills;

namespace SiteManagement.Application.Features.Commands.Bills.AddBill
{
    public class AddBillCommand : AddBillDto, IRequest<int>
    {
    }
}
