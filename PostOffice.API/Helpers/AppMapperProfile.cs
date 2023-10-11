using AutoMapper;
using PostOffice.API.Data.Models;
using PostOffice.API.DTOs.Area;
using PostOffice.API.DTOs.Branch;
using PostOffice.API.DTOs.Pincode;

namespace PostOffice.API.Helpers
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            CreateMap<PincodeBaseDTO, Pincode>();
            CreateMap<AreaBaseDTO, Area>().ReverseMap(); ;
            CreateMap<AreaCreateDTO, Area>();
            CreateMap<AreaUpdateDTO, Area>();
            CreateMap<OfficeBranch, OfficeBranchBaseDTO>();

        }
    }
}
