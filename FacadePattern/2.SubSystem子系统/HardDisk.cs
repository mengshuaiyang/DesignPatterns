using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HardDisk
    {
        public void Start()
        {
            Console.WriteLine("Hard Disk is starting...");
        }
        public void Shutdown()
        {
            Console.WriteLine("Hard Disk is shutting down...");
        }
    }
}
