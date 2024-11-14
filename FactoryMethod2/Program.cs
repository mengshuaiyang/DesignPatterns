using FactoryMethod2.ConcreteFactory;
using FactoryMethod2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////店铺
            //PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
            //pizzaStore.OrderPizza("Chesse");
            //pizzaStore.OrderPizza("Clam");
            //pizzaStore.OrderPizza("Pepperoni");
            //pizzaStore.OrderPizza("Veggle");

            //工厂
            PizzaFactory factory = new ChicagoPizzaFactory();
            factory.CreateChessePizza();

            Console.Read();
        }
    }
}
