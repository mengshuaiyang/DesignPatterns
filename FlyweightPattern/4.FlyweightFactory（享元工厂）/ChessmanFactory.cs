using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // 享元工厂
    public class ChessmanFactory
    {
        private Dictionary<string, IChessman> _chessmen = new Dictionary<string, IChessman>();

        public IChessman GetChessman(string color)
        {
            if (!_chessmen.ContainsKey(color))
            {
                _chessmen[color] = new Chessman(color);
            }
            return _chessmen[color];
        }
    }

}
