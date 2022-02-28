﻿using MediatR;
using SiteManagement.Application.Models.Flats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Flats.AddFlat
{
    public class AddFlatCommand : AddFlatDto, IRequest<int>
    {
    }
}