using Automobile_Production.AssemblyLines;
using Automobile_Production.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automobile_Production.Services
{
    class HQ
    {
        private Queue<ICommand> carOrders;

        private Queue<ICommand> minibusOrders;

        private CarAssemblyLine carAssemblyLine;

        private MinibusAssemblyLine minibusAssemblyLine;

        public HQ()
        {
            carOrders = new Queue<ICommand>();
            minibusOrders = new Queue<ICommand>();

            carAssemblyLine = new CarAssemblyLine();
            minibusAssemblyLine = new MinibusAssemblyLine();

            StartProcessing();
        }

        public CarAssemblyLine CarAssemblyLine
        {
            get { return carAssemblyLine; }
        }

        public MinibusAssemblyLine MinibusAssemblyLine
        {
            get { return minibusAssemblyLine; }
        }

        public void OrderCar(string colour)
        {
            carOrders.Enqueue(
                new BuildCarCommand(carAssemblyLine, colour));
        }

        public void OrderMinibus(string colour)
        {
            minibusOrders.Enqueue(
                new BuildMinibusCommand(minibusAssemblyLine, colour));
        }

        private void StartProcessing()
        {
            Thread carThread = new Thread(ProcessCars);

            Thread minibusThread = new Thread(ProcessMinibuses);

            carThread.IsBackground = true;

            minibusThread.IsBackground = true;

            carThread.Start();

            minibusThread.Start();
        }

        private void ProcessCars()
        {
            while (true)
            {
                if (carOrders.Count > 0)
                {
                    ICommand command = carOrders.Dequeue();

                    command.Execute();
                }

                Thread.Sleep(100);
            }
        }

        private void ProcessMinibuses()
        {
            while (true)
            {
                if (minibusOrders.Count > 0)
                {
                    ICommand command = minibusOrders.Dequeue();

                    command.Execute();
                }

                Thread.Sleep(100);
            }
        }

        public int CarQueueCount
        {
            get { return carOrders.Count; }
        }

        public int MinibusQueueCount
        {
            get { return minibusOrders.Count; }
        }
    }
}
