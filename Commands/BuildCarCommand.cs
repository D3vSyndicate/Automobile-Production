using Automobile_Production.AssemblyLines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Production.Commands
{
    class BuildCarCommand : ICommand
    {
        private CarAssemblyLine assemblyLine;

        private string colour;

        public BuildCarCommand(CarAssemblyLine assemblyLine, string colour)
        {
            this.assemblyLine = assemblyLine;
            this.colour = colour;
        }

        public void Execute()
        {
            assemblyLine.BuildCar(colour);
        }
    }
}
