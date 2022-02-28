using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.DeleteFlatOfUser
{
    public class DeleteFlatOfUserCommand : IRequest
    {
        public int Id { get; set; }
    }
}
