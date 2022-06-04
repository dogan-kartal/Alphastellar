using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.Business.Abstract
{
    public interface IBoatService
    {
        List<Boat> GetBoatByColor(string color);
    }
}
