using MediatR;

namespace SiteManagement.Application.Features.Commands.Fees.DeleteFee

{
    public class DeleteFeeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
