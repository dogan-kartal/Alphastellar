using Alphastellar.DataAccess.Abstract;
using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alphastellar.DataAccess.Concrete
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int id)
        {
            using (var alphastellarDbContext = new AlphastellarDbContext())
            {
                var deletedCar = alphastellarDbContext.Cars.Find(id);
                alphastellarDbContext.Cars.Remove(deletedCar);
                alphastellarDbContext.SaveChanges();
            }
        }

        public List<Car> GetCarByColor(string color)
        {
            using (var alphastellarDbContext = new AlphastellarDbContext())
            {
                return alphastellarDbContext.Cars.Where(x => x.Color == color).ToList();
            }
        }

        public void SetHeadlightsOfCar(int id)
        {
            using (var alphastellarDbContext = new AlphastellarDbContext())
            {
                var setCar = alphastellarDbContext.Cars.Find(id);
                setCar.Headlights = !setCar.Headlights;
                alphastellarDbContext.SaveChanges();
            }
        }
    }
}
