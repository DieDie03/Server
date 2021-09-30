using MakerHub.API.DTO;
using MakerHub.API.Services;
using MakerHub.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private MakerHubService mService;

        public ValuesController(MakerHubService mService)
        {
            this.mService = mService;
        }

        //public ValuesController(MakerHubDBContext c)
        //{

        //}
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Ok(mService.Read());
        //}

        [HttpPost("post")]
        public IActionResult AddIntensity(SoundDTO form)
        {
            mService.Create(form);
            return NoContent();
        }

        [HttpGet("sound")]
        public IActionResult GetAllSounds()
        {
            return Ok(mService.ReadSound());
        }
    }
}
