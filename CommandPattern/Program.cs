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

            ICommand command = new LightCommand(new Light());
            remoteControl.SetCommand(command);

            remoteControl.PressButton();
            remoteControl.PressButton();


            ICommand command2 = new StereoCommand(new Stereo());
            remoteControl.SetCommand(command2);

            remoteControl.PressButton();
            remoteControl.PressButton();

            Console.ReadKey();
        }
    }
}
