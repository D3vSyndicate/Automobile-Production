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
            Minibus minibus = new Minibus(colour);

            Status = $"Building {minibus} Chassis";
            factory.CreateChassis();

            Status = $"Building {minibus} Shell";
            factory.CreateShell();


            Status = $"Building {minibus} Right Front Wheel";
            factory.CreateWheel();
            Status = $"Building {minibus} Left Front Wheel";
            factory.CreateWheel();
            Status = $"Building {minibus} Right Back Wheel";
            factory.CreateWheel();
            Status = $"Building {minibus} Left Back Wheel";
            factory.CreateWheel();
            

            Status = $"Building {minibus} Trim";
            factory.CreateTrim();

            Status = $"Performing final assembly of {minibus}";
            Thread.Sleep(3000);


            Status = $"Sent {minibus} for painting";

            Spraybooth.Instance.PaintVehicle(minibus);

            Status = "Minibus Successfully Completed!";

            MinibusesBuilt++;

            Thread.Sleep(1000);

            Status = "Idle";
        }
    }
}
