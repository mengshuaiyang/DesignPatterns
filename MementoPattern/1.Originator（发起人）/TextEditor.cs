using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 发起人
    /// 创建一个备忘录对象，用以记录当前时刻的内部状态，并可以使用备忘录对象恢复内部状态。
    /// </summary>
    public class TextEditor
    {
        private string _text;

        public void Type(string text)
        {
            _text += text;
        }

        public TextMemento Save()
        {
            return new TextMemento(_text);
        }

        public void Restore(TextMemento memento)
        {
            _text = memento.GetText();
        }

        public string GetText()
        {
            return _text;
        }
    }
}
