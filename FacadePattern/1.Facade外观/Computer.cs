using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // 外观
    public class Computer
    {
        private CPU _cpu;
        private Memory _memory;
        private HardDisk _hardDisk;

        public Computer()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _hardDisk = new HardDisk();
        }

        public void StartComputer()
        {
            _cpu.Start();
            _memory.Start();
            _hardDisk.Start();
            Console.WriteLine("Computer is starting...");
        }

        public void ShutdownComputer()
        {
            _cpu.Shutdown();
            _memory.Shutdown();
            _hardDisk.Shutdown();
            Console.WriteLine("Computer is shutting down...");
        }
    }
}
