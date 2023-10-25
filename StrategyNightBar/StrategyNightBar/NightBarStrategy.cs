using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar          //Strategy
{
    public abstract class NightBarStrategy
    {
        public abstract void Calculate(double amount);
    }
}
