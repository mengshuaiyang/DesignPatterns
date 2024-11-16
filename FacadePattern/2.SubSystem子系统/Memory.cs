using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Memory
    {
        public void Start()
        {
            Console.WriteLine("Memory is starting...");
        }
        public void Shutdown()
        {
            Console.WriteLine("Memory is shutting down...");
        }
    }
}
