using System;
using System.Collections.Generic;
using System.Text;

namespace Alphastellar.Entities
{
    public class Car : Vehicle
    {
        public int Id { get; set; }
        public string Wheels { get; set; }
        public bool Headlights { get; set; }
    }
}
