using Alphastellar.Business.Abstract;
using Alphastellar.DataAccess.Abstract;
using Alphastellar.DataAccess.Concrete;
using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarRepository _carRepository;

        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> GetCarByColor(string color)
        {
            return _carRepository.GetCarByColor(color);
        }

        public void SetHeadlightsOfCar(int id)
        {
            _carRepository.SetHeadlightsOfCar(id);
        }
    }
}
