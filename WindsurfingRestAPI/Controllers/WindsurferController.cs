﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WindsurfingRestAPI.Models;
using WindsurfingRestAPI.Services;

namespace WindsurfingRestAPI.Controllers
{
    [ApiController]
    public class WindsurferController : ControllerBase
    {
        //fundamental dependancy injection part 
        private readonly IWindsurfingRepository _windsurfingRepository;
        private readonly IMapper _mapper; 
        public WindsurferController(IWindsurfingRepository windsurfingRepository, IMapper mapper)
        {
            _windsurfingRepository = windsurfingRepository ?? throw new ArgumentNullException(nameof(windsurfingRepository));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        //we have to be able to right the exact paths for our API !! 
        [HttpGet("api/windsurfers/{SPOTname}")]
        public async Task<ActionResult<WindsurferDTO>> GetAllSPOTWindsurfers(string SPOTname)
        {
            if ( SPOTname == null ) { return  NotFound();  }
            var exactwindsurfers = await _windsurfingRepository.GetAllSPOTWindsurfers(SPOTname);
            //mapping the data to windsurferDTO  : 
            return Ok(_mapper.Map<IEnumerable<WindsurferDTO>>(exactwindsurfers));    

        }
        [HttpPost("api/windsurfers")]
        public async Task<IActionResult> AddWindsurfer (WindsurferDTO newWindsurfer)
        {
            var originalentity = _mapper.Map<Entities.Windsurfer>(newWindsurfer); 
            _windsurfingRepository.AddSurfer(originalentity); 
            await _windsurfingRepository.SaveAsync();
            return Ok(); 
        }




    }

}
