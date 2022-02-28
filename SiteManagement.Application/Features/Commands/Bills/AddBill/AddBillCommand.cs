using MediatR;
using SiteManagement.Application.Models.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Bills.AddBill
{
    public class AddBillCommand : AddBillDto, IRequest<int>
    {
    }
}
