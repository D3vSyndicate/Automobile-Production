using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Production.Models.Vehicles
{
    class Minibus : Vehicle
    {
        public Minibus(string colour)
        {
            Model = "MV500";
            Colour = colour;
        }
    }
}
