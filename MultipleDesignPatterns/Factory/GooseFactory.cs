using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDesignPatterns.Factory
{
    public class GooseFactory : AbstractGooseFactory
    {
        public override Quackable CreateGooses()
        {
            return new GoosesAdapter(new Gooses());
        }
    }
}
