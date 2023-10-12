using AutoMapper;
using Models;
using Models.DTOs.ParcelOrder;
using Models.DTOs.ParcelService;
using Models.DTOs.ParcelServicePrice;
using Models.DTOs.ParcelType;
using Models.DTOs.WeightScope;

namespace PostOffice.API.ProfileMapper
{
    public class AutoMapperProfile : Profile   
    {
        public AutoMapperProfile() 
        {
            CreateMap<WeightScopeBaseDTO, WeightScope>();
            CreateMap<WeightScopeCreateDTO, WeightScope>();
            CreateMap<WeightScopeUpdateDTO, WeightScope>();

            CreateMap<ServicePriceBaseDTO, ParcelServicePrice>();
            CreateMap<ParcelServiceBaseDTO, ParcelService>();
            CreateMap<ParcelServiceCreateDTO, ParcelService>();

            CreateMap<ParcelTypeBaseDTO, ParcelType>();
            CreateMap<ParcelTypeCreateDTO, ParcelType>();
            CreateMap<ParcelTypeUpdateDTO, ParcelType>();

            CreateMap<ParcelOrderBase, ParcelOrder>();
            CreateMap<ParcelOrderCreateDTO, ParcelOrder>();
            CreateMap<ParcelOrderUpdateDTO, ParcelOrder>();

            CreateMap<ServicePriceCreateDTO, ParcelServicePrice>();
            CreateMap<ServicePriceUpdateDTO, ParcelServicePrice>();





        }
    }
}
