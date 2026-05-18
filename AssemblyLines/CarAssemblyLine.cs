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
        private  CarPartsFactory factory;

        public int CarsBuilt { get; set; }

        public CarAssemblyLine()
        {
            factory = new CarPartsFactory();

            Status = "Idle";
        }

        public async Task BuildCar(string colour)
        {
            Car car = new Car(colour);

            Status = $"Building {car} Chassis";
            factory.CreateChassis();

            Status = $"Building {car} Shell";
            factory.CreateShell();

            Status = $"Building {car} Right Front Wheel";
            factory.CreateWheel();
            Status = $"Building {car} Left Front Wheel";
            factory.CreateWheel();
            Status = $"Building {car} Right Back Wheel";
            factory.CreateWheel();
            Status = $"Building {car} Left Back Wheel";
            factory.CreateWheel();


            Status = $"Building {car} Trim";
            factory.CreateTrim();

            Status = $"Perfoming final assembly of {car}";
            Thread.Sleep(2000);

            Status = $"Sent {car} for painting";

            await Spraybooth.Instance.PaintVehicle(car);

            Status = "Car Successfully Completed!";

            CarsBuilt++;

            Thread.Sleep(1000);

            Status = "Idle";
        }
    }
}
