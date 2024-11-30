using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ChessmanFactory();
            var blackPawn1 = factory.GetChessman("black");
            var blackPawn2 = factory.GetChessman("black");

            blackPawn1.Place(1, 1);
            blackPawn2.Place(2, 2);

            Console.ReadKey();
        }
    }
}
