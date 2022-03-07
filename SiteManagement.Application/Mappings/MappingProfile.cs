using AutoMapper;
using SiteManagement.Application.Models.Bills;
using SiteManagement.Application.Models.Fees;
using SiteManagement.Application.Models.Flats;
using SiteManagement.Application.Models.FlatsOfUsers;
using SiteManagement.Domain.Entities.Contracts;

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
