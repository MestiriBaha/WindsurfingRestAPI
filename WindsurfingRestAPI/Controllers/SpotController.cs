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
          //  throw new Exception("testing exceptipn "); 
            var result =   await _windsurfingRepository.GetSpotsAsync()  ;
            var resultDTO = _mapper.Map<IEnumerable<SpotDTO>>(result) ;
            return Ok(resultDTO); 
        }
        [HttpGet("api/spots/{windsurferID}")]
        public async Task<ActionResult<IEnumerable<SpotDTO>>> GetSpotsofWindsurfer (int windsurferid)
        {
            if (! await _windsurfingRepository.IswindsurferExistsAsync(windsurferid)) { return NotFound();  } ; 
           var result= await _windsurfingRepository.GetSpotsAsync(windsurferid) ;
            var resultDTO = _mapper.Map<IEnumerable<SpotDTO>>(result) ;
            return Ok(resultDTO);
        }


    }
}
