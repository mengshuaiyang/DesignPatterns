using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns.Factory
{
    public abstract class AbstractGooseFactory
    {
        public abstract Quackable CreateGooses();
    }
}
