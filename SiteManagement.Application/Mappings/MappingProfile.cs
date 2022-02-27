using AutoMapper;
using SiteManagement.Application.Models.Flats;
using SiteManagement.Application.Models.FlatsOfUsers;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Flat, AddFlatDto>().ReverseMap();
            CreateMap<FlatOfUser, AddFlatOfUserDto>().ReverseMap();
        }
    }
}
