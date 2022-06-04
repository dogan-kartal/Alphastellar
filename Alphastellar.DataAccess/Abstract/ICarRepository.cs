using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.DataAccess.Abstract
{
    public interface ICarRepository
    {
        List<Car> GetCarByColor(string color);

        void DeleteCar(int id);

        void SetHeadlightsOfCar(int id);
    }
}
