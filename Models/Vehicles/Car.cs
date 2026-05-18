using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Production.Models.Vehicles
{
    class Car : Vehicle
    {
        public Car(string colour)
        {
            Model = "LUX1000";
            Colour = colour;
        }
    }
}
