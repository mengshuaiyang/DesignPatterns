using FactoryMethod2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2.ConcreteFactory
{
    public class ChicagoPizzaFactory : PizzaFactory
    {
        public void CreateChessePizza()
        {
            Pizza pizza = new ChessePizza();
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
