using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarByColor(string color);

        void DeleteCar(int id);

        void SetHeadlightsOfCar(int id);
    }
}
