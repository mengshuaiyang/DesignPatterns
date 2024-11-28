using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerDirector
    {
        private IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public Computer Construct()
        {
            _builder.BuildCpu();
            _builder.BuildRam();
            _builder.BuildHardDrive();
            return _builder.GetComputer();
        }
    }
}
