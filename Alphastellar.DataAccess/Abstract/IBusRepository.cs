using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.DataAccess.Abstract
{
    public interface IBusRepository
    {
        List<Bus> GetBusByColor(string color);
    }
}
