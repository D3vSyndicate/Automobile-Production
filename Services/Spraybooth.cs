using Automobile_Production.Models.Vehicles;
using System;
using System.Threading.Tasks;

namespace Automobile_Production.Services
{
    class Spraybooth
    {
        private static readonly Lazy<Spraybooth> instance =
            new Lazy<Spraybooth>(() => new Spraybooth());

        public static Spraybooth Instance => instance.Value;

        public string Status { get; private set; }

        private readonly object padlock = new object();

        private Spraybooth()
        {
            Status = "Idle";
        }

        public async Task PaintVehicle(Vehicle vehicle)
        {
            lock (padlock)
            {
                Status = $"Painting {vehicle}";
            }

            int paintTime = vehicle is Car ? 5000 : 7000;
            await Task.Delay(paintTime);

            vehicle.IsPainted = true;

            lock (padlock)
            {
                Status = "Idle";
            }
        }
    }
}
