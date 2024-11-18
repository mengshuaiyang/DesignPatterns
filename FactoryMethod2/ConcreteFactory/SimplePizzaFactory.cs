using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "Chesse")
            {
                pizza = new ChessePizza();
            }
            else if (type == "Clam")
            {
                pizza = new ClamPizza();
            }
            else if (type == "Pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "Veggle")
            {
                pizza = new VegglePizza();
            }
            return pizza;
        }
    }
}
