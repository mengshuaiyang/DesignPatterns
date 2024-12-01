using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo Open");
        }
        public void Off()
        {
            Console.WriteLine("Stereo Close");
        }
        public void SetCD()
        {
            Console.WriteLine("Set CD");
        }
        public void SetDVD()
        {
            Console.WriteLine("Set DVD");
        }
        public void SetRadio()
        {
            Console.WriteLine("Set Radio");
        }
        public void SetVolume()
        {
            Console.WriteLine("Set Volume");
        }
    }
}
