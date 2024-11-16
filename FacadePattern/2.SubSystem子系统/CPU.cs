using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CPU
    {
        public void Start()
        {
            Console.WriteLine("CPU is starting...");
        }
        public void Shutdown()
        {
            Console.WriteLine("CPU is shutting down...");
        }
    }
}
