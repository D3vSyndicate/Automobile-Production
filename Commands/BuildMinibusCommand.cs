using Automobile_Production.AssemblyLines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Production.Commands
{
    class BuildMinibusCommand : ICommand
    {
        private MinibusAssemblyLine assemblyLine;

        private string colour;

        public BuildMinibusCommand(MinibusAssemblyLine assemblyLine, string colour)
        {
            this.assemblyLine = assemblyLine;
            this.colour = colour;
        }

        public void Execute()
        {
            assemblyLine.BuildMinibus(colour);
        }
    }
}
