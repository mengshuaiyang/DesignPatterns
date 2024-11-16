using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TextAdapter : Shape
    {
        private TextView _textView;
        public TextAdapter() 
        {
            _textView = new TextView();
        }

        public void BoundIngBox()
        {
            _textView.GetExtent();
        }

        public void CreateManipuator()
        {
            Console.WriteLine("未实现");
        }
    }
}
