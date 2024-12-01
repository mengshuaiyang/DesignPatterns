using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录
    /// 负责存储发起人的内部状态，并可以防止发起人的外部状态被访问。
    /// </summary>
    public class TextMemento
    {
        private string _text;

        public TextMemento(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
