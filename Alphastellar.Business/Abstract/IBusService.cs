using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.Business.Abstract
{
    public interface IBusService
    {
        List<Bus> GetBusByColor(string color);
    }
}
