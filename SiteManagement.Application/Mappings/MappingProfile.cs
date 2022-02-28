using AutoMapper;
using SiteManagement.Application.Features.Commands.Bills.UpdateBill;
using SiteManagement.Application.Models.Bills;
using SiteManagement.Application.Models.Fees;
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
            CreateMap<Fee, AddFeeDto>().ReverseMap();
            CreateMap<Bill, AddBillDto>().ReverseMap();
        }
    }
}
