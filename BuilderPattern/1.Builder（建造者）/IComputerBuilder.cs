using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // 建造者接口
    public interface IComputerBuilder
    {
        void BuildCpu();
        void BuildRam();
        void BuildHardDrive();
        Computer GetComputer();
    }
}
