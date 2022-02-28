using MediatR;
using SiteManagement.Application.Models.FlatsOfUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.AddFlatOfUser
{
    public class AddFlatOfUserCommand : AddFlatOfUserDto, IRequest<int>
    {
    }
}
