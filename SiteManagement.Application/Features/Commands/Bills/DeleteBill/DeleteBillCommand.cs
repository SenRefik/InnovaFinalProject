using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Bills.DeleteBill
{
    public class DeleteBillCommand : IRequest
    {
        public int Id { get; set; }
    }
}
