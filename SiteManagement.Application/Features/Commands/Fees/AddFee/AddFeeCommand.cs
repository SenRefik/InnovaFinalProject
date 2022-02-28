using MediatR;
using SiteManagement.Application.Models.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Fees.AddFee
{
    public class AddFeeCommand : AddFeeDto, IRequest<int>
    {
    }
}
