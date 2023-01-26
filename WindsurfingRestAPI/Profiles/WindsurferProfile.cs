using AutoMapper;
using WindsurfingRestAPI.Models;
using WindsurfingRestAPI.Entities; 

namespace WindsurfingRestAPI.Profiles
{
    public class WindsurferProfile : Profile
    {
        public WindsurferProfile() {
            CreateMap<Entities.Windsurfer, Models.WindsurferDTO>()
                .ForMember(mapp => mapp.FirstName)


                }
            
    }
}
