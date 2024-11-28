using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // 具体建造者
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCpu()
        {
            _computer.Cpu = "Intel i7";
        }

        public void BuildRam()
        {
            _computer.Ram = "16GB";
        }

        public void BuildHardDrive()
        {
            _computer.HardDrive = "1TB";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
