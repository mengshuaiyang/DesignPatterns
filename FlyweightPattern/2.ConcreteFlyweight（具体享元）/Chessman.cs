using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // 具体享元
    public class Chessman : IChessman
    {
        private string _color; // 内部状态

        public Chessman(string color)
        {
            _color = color;
        }

        public void Place(int x, int y)
        {
            Console.WriteLine($"Place {_color} chessman at ({x}, {y})");
        }
    }
}
