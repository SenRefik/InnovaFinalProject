using MediatR;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Fees.UpdateFee
{
    public class UpdateFeeCommand : Fee, IRequest
    {
    }
}
