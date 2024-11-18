using CommandPattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light light=new Light();
            ICommand command = new LightCommand(light);
            remoteControl.SetCommand(command);

            remoteControl.PressButton();
            remoteControl.PressButton();

            Stereo stereo = new Stereo();
            ICommand command2 = new StereoCommand(stereo);
            remoteControl.SetCommand(command2);

            remoteControl.PressButton();
            remoteControl.PressButton();

            Console.ReadKey();
        }
    }
}
