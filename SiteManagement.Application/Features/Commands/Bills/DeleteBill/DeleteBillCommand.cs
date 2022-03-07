using MediatR;

namespace SiteManagement.Application.Features.Commands.Bills.DeleteBill
{
    public class DeleteBillCommand : IRequest
    {
        public int Id { get; set; }
    }
}
