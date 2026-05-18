using Automobile_Production.Factories;
using Automobile_Production.Models.Vehicles;
using Automobile_Production.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automobile_Production.AssemblyLines
{
    class MinibusAssemblyLine : AssemblyLine
    {
        private MinibusPartsFactory factory;

        public int MinibusesBuilt { get; set; }

        public MinibusAssemblyLine()
        {
            factory = new MinibusPartsFactory();

            Status = "Idle";
        }

        public void BuildMinibus(string colour)
        {
            Status = "Building Minibus Chassis";
            factory.CreateChassis();

            Status = "Building Minibus Shell";
            factory.CreateShell();

            Status = "Building Minibus Wheels";

            for (int i = 0; i < 4; i++)
            {
                factory.CreateWheel();
            }

            Status = "Building Minibus Trim";
            factory.CreateTrim();

            Status = "Assembling Minibus";
            Thread.Sleep(3000);

            Minibus minibus = new Minibus(colour);

            Status = "Waiting For Spraybooth";

            Spraybooth.Instance.PaintVehicle(minibus);

            Status = "Minibus Completed";

            MinibusesBuilt++;

            Thread.Sleep(1000);

            Status = "Idle";
        }
    }
}
