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
    class CarAssemblyLine : AssemblyLine
    {
        private CarPartsFactory factory;

        public int CarsBuilt { get; set; }

        public CarAssemblyLine()
        {
            factory = new CarPartsFactory();

            Status = "Idle";
        }

        public void BuildCar(string colour)
        {
            Status = $"Building {colour} LUX1000 Chassis";
            factory.CreateChassis();

            Status = $"Building {colour} LUX1000 Shell";
            factory.CreateShell();

            Status = $"Building {colour} LUX1000 Wheels";

            for (int i = 0; i < 4; i++)
            {
                factory.CreateWheel();
            }

            Status = $"Building {colour} LUX1000 Trim";
            factory.CreateTrim();

            Status = "Assembling Car";
            Thread.Sleep(2000);

            Car car = new Car(colour);

            Status = "Waiting For Spraybooth";

            Spraybooth.Instance.PaintVehicle(car);

            Status = "Car Completed";

            CarsBuilt++;

            Thread.Sleep(1000);

            Status = "Idle";
        }
    }
}
