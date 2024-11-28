using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // 产品
    public class Computer
    {
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string HardDrive { get; set; }

        public void ShowSpecs()
        {
            Console.WriteLine($"CPU: {Cpu}, RAM: {Ram}, Hard Drive: {HardDrive}");
        }
    }
}
