using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alphastellar.Business.Abstract;
using Alphastellar.Business.Concrete;
using Alphastellar.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("{color}")]
        public List<Boat> GetBoatsByColor(string color)
        {
            return _boatService.GetBoatByColor(color);
        }
    }
}
