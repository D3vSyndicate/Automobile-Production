using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Production.Models.Vehicles
{
    abstract class Vehicle
    {
        public string Model { get; set; }

        public string Colour { get; set; }

        public bool IsPainted { get; set; }

        public override string ToString()
        {
            return $"{Colour} {Model}";
        }
    }
}
