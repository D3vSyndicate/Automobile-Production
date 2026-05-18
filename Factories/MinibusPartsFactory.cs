using Automobile_Production.Models.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automobile_Production.Factories
{
    class MinibusPartsFactory : IVehiclePartsFactory
    {
        public Chassis CreateChassis()
        {
            Thread.Sleep(2000);
            return new Chassis();
        }

        public Shell CreateShell()
        {
            Thread.Sleep(3000);
            return new Shell();
        }

        public Wheel CreateWheel()
        {
            Thread.Sleep(500);
            return new Wheel();
        }

        public Trim CreateTrim()
        {
            Thread.Sleep(2000);
            return new Trim();
        }
    }
}
