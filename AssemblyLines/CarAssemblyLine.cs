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
            Car car = new Car(colour);

            Status = $"Creating {car} Chassis";
            factory.CreateChassis();

            Status = $"Creating {car} Shell";
            factory.CreateShell();

            Status = $"Creating {car} Right Front Wheel";
            factory.CreateWheel();

            Status = $"Creating {car} Left Front Wheel";
            factory.CreateWheel();

            Status = $"Creating {car} Right Rear Wheel";
            factory.CreateWheel();

            Status = $"Creating {car} Left Rear Wheel";
            factory.CreateWheel();

            Status = $"Creating {car} Trim";
            factory.CreateTrim();

            Status = $"Performing final assembly of {car}";
            Thread.Sleep(2000);

            Status = $"Sent {car} for painting";

            Spraybooth.Instance.PaintVehicle(car);

            Status = $"{car} Completed";

            CarsBuilt++;

            Thread.Sleep(1000);

            Status = "Idle";
        }
    }
}
