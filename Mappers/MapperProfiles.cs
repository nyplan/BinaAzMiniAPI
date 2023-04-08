using AutoMapper;
using BinaAzAPI.DTOs.AdDTOs;
using BinaAzAPI.DTOs.PictureDTOs;
using BinaAzAPI.Entities;

namespace BinaAzAPI.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Ad, AdToListDto>()
                .ForMember(dest => dest.ApartmentType, src => src.MapFrom(c => c.ApartmentType.Value))
                .ForMember(dest => dest.ActionType, src => src.MapFrom(c => c.ActionType.Value))
                .ForMember(dest => dest.City, src => src.MapFrom(c => c.City.Name))
                .ForMember(dest => dest.Rooms, src => src.MapFrom(c => c.Rooms.Value))
                .ForMember(dest => dest.PricePerDayMonth, src => src.MapFrom(c => c.PricePerDayMonth.Value))
                .ForMember(dest => dest.Repair, src => src.MapFrom(c => c.Repair.Value))
                .ForMember(dest => dest.District, src => src.MapFrom(c => c.District.Name))
                .ForMember(dest => dest.Township, src => src.MapFrom(c => c.Township.Name))
                .ForMember(dest => dest.AdOwner, src => src.MapFrom(c => c.AdOwner.Value));
            CreateMap<Ad, AdByIdDto>()
                .ForMember(dest => dest.ApartmentType, src => src.MapFrom(c => c.ApartmentType.Value))
                .ForMember(dest => dest.ActionType, src => src.MapFrom(c => c.ActionType.Value))
                .ForMember(dest => dest.City, src => src.MapFrom(c => c.City.Name))
                .ForMember(dest => dest.Rooms, src => src.MapFrom(c => c.Rooms.Value))
                .ForMember(dest => dest.PricePerDayMonth, src => src.MapFrom(c => c.PricePerDayMonth.Value))
                .ForMember(dest => dest.Repair, src => src.MapFrom(c => c.Repair.Value))
                .ForMember(dest => dest.District, src => src.MapFrom(c => c.District.Name))
                .ForMember(dest => dest.Township, src => src.MapFrom(c => c.Township.Name))
                .ForMember(dest => dest.AdOwner, src => src.MapFrom(c => c.AdOwner.Value));
            CreateMap<AdToAddDto, Ad>();
            CreateMap<AdToUpdateDto, Ad>();


            CreateMap<PictureToAddDto, Picture>();
            CreateMap<Picture, PictureToListDto>();
        }
    }
}
