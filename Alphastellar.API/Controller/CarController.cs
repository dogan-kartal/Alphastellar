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
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("{color}")]
        public List<Car> GetCarByColor(string color)
        {
            return _carService.GetCarByColor(color);
        }

        [HttpDelete("{id}")]
        public void DeleteCar(int id)
        {
            _carService.DeleteCar(id);
        }

        [HttpPost("setHeadlights/{id}")]
        public void SetHeadlightsOfCar(int id)
        {
            _carService.SetHeadlightsOfCar(id);
        }
    }
}
