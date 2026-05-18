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
            lock (padlock)
            {
                Status = $"Painting {vehicle}";

                if (vehicle is Car)
                {
                    Thread.Sleep(5000);
                }
                else
                {
                    Thread.Sleep(7000);
                }

                vehicle.IsPainted = true;

                Status = "Idle";
            }
        }
    }
}
