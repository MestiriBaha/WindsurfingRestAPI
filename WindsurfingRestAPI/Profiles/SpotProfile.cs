using AutoMapper;

namespace WindsurfingRestAPI.Profiles
{
    public class SpotProfile : Profile
    {
        public SpotProfile()
        {
            CreateMap<Entities.Spot, Models.SpotDTO>()
            .ForMember(dest => dest.NameCountry, opt =>
            opt.MapFrom(src => $"{src.Name} {src.country}"))
        .ForMember(dest => dest.Description, opt =>
            opt.MapFrom(src => src.Description))
        .ForMember(dest => dest.Hearts, opt =>
            opt.MapFrom(src => src.Hearts));

        }

    }
}
