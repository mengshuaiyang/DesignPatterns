using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoCommand : ICommand
    {
        private Stereo _stereo;

        public StereoCommand(Stereo stereo) 
        {
            _stereo = stereo;
        }

        void ICommand.Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume();
        }

        void ICommand.Undo()
        {
            _stereo.Off();
        }
    }
}
