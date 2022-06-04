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
    public class BusController : ControllerBase
    {
        private IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("{color}")]
        public List<Bus> GetBusByColor(string color)
        {
            return _busService.GetBusByColor(color);
        }
    }
}
