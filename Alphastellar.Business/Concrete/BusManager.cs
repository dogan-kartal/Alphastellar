using Alphastellar.Business.Abstract;
using Alphastellar.DataAccess.Abstract;
using Alphastellar.DataAccess.Concrete;
using Alphastellar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.Business.Concrete
{
    public class BusManager : IBusService
    {
        private IBusRepository _busRepository;

        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public List<Bus> GetBusByColor(string color)
        {
            return _busRepository.GetBusByColor(color);
        }
    }
}
