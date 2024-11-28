using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerBuilder builder = new ComputerBuilder();
            ComputerDirector computerDirector = new ComputerDirector(builder);

            computerDirector.Construct();
            
            Console.ReadKey();
        }
    }
}
