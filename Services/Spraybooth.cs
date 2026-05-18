using Automobile_Production.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automobile_Production.Services
{
    class Spraybooth
    {
        private static Spraybooth instance;

        private static readonly object padlock = new object();

        private readonly object boothLock = new object();

        public string Status { get; set; }

        private Spraybooth()
        {
            Status = "Idle";
        }

        public static Spraybooth Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Spraybooth();
                    }

                    return instance;
                }
            }
        }

        public void PaintVehicle(Vehicle vehicle)
        {
            lock (boothLock)
            {
                // UPDATE STATUS
                Status = $"Spraying and drying {vehicle}";

                // PAINTING TIME
                Thread.Sleep(100);

                if (vehicle is Car)
                {
                    Thread.Sleep(5000);
                }
                else
                {
                    Thread.Sleep(7000);
                }

                // VEHICLE DONE
                vehicle.IsPainted = true;

                // RESET STATUS
                Status = "Idle";

                Console.WriteLine(Status);
            }
        }
    }
}
