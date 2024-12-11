using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            IObserver d1 = new TJDisplay(weatherData);
            IObserver d2 = new YCDisplay(weatherData);
            IObserver d3 = new ZKDisplay(weatherData);

            //weatherData.RegisterObserver(d1);
            //weatherData.RegisterObserver(d2);
            //weatherData.RegisterObserver(d3);

            weatherData.SetChange("天气数据变化了，温度升高了");

            weatherData.RemoveObserver(d3);

            weatherData.SetChange("天气数据变化了，温度降低了");


            weatherData.RemoveObserver(d1);
;
            weatherData.SetChange("天气数据变化了，温度不变了");

            Console.ReadKey();
        }
    }
}
