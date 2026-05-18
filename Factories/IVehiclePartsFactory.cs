using Automobile_Production.Models.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Production.Factories
{
    interface IVehiclePartsFactory
    {
        Chassis CreateChassis();

        Shell CreateShell();

        Wheel CreateWheel();

        Trim CreateTrim();
    }
}
