using Alphastellar.Business.Abstract;
using Alphastellar.DataAccess.Abstract;
using Alphastellar.DataAccess.Concrete;
using Alphastellar.Entities;
using System;
using System.Collections.Generic;

namespace Alphastellar.Business.Concrete
{
    public class BoatManager : IBoatService
    {
        private IBoatRepository _boatRepository;

        public BoatManager(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        public List<Boat> GetBoatByColor(string color)
        {
            return _boatRepository.GetBoatByColor(color);
        }
    }
}
