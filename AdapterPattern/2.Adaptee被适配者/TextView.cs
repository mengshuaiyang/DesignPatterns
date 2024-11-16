using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// (Adaptee)
    /// </summary>
    public class TextView
    {
        public void GetExtent()
        {
            Console.WriteLine("{0}GetExtent()方法", this.GetType());
        }
    }
}
