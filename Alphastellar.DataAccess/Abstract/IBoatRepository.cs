using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.DataAccess.Abstract
{
    public interface IBoatRepository
    {
        List<Boat> GetBoatByColor(string color);
    }
}
