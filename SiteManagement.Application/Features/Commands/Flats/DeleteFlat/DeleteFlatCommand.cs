using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Flats.DeleteFlat
{
    public class DeleteFlatCommand : IRequest
    {
        public int Id { get; set; }
    }
}
