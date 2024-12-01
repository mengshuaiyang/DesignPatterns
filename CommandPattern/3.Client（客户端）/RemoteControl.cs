using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Client
{
    public class RemoteControl
    {
        private ICommand _command;

        private bool IsOpen=true;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            if (IsOpen)
            {
                _command.Execute();
            }
            else
            {
                _command.Undo();
            }
            IsOpen = !IsOpen;
        }
    }
}
