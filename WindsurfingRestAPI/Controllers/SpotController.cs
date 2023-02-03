using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WindsurfingRestAPI.Entities;
using WindsurfingRestAPI.Models;
using WindsurfingRestAPI.Services;

namespace WindsurfingRestAPI.Controllers
{
    [ApiController]
    public class SpotController : ControllerBase
    {
        private readonly IWindsurfingRepository _windsurfingRepository;
        private readonly IMapper _mapper; 
        public SpotController(IWindsurfingRepository windsurfingRepository, IMapper mapper)
        {
            _windsurfingRepository = windsurfingRepository ?? throw new ArgumentNullException(nameof(WindsurfingRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }   
        [HttpGet("api/spots")]   
        public async Task<ActionResult<IEnumerable<SpotDTO>>> GetSpotsAsync()
        {
            var result =   await _windsurfingRepository.GetSpotsAsync()  ;
            var resultDTO = _mapper.Map<IEnumerable<SpotDTO>>(result) ;
            return Ok(resultDTO); 
        }
        [HttpGet("api/{windsurferID}/spots")]
        Task<IEnumerable<SpotDTO>> GetSpotsofWindsurfer (int windsurfer)
        {
            throw new NotImplementedException(); 
        }


    }
}
