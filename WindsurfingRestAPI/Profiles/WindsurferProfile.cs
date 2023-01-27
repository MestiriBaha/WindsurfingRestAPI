using AutoMapper;
using WindsurfingRestAPI.Models;
using WindsurfingRestAPI.Entities;
using WindsurfingRestAPI.Helpers; 

namespace WindsurfingRestAPI.Profiles
{
    public class WindsurferProfile : Profile
    {
        public WindsurferProfile() {
            CreateMap<Entities.Windsurfer, Models.WindsurferDTO>()
                .ForMember(dest => dest.FullName, opt =>
                opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ForMember(dest => dest.Age, opt =>
                opt.MapFrom(src => src.Birthday.GetCurrentAge()))
            .ForMember(dest => dest.Nationality, opt =>
                opt.MapFrom(src => src.Nationality))
            .ForMember(dest=>dest.password,opt => opt.MapFrom(src => src.password));



        }

    }
}
