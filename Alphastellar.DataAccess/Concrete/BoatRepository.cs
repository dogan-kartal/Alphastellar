using Alphastellar.DataAccess.Abstract;
using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alphastellar.DataAccess.Concrete
{
    public class BoatRepository : IBoatRepository
    {
        public List<Boat> GetBoatByColor(string color)
        {
            using (var alphastellarDbContext = new AlphastellarDbContext())
            {
                return alphastellarDbContext.Boats.Where(x => x.Color == color).ToList();
            }
        }
    }
}
