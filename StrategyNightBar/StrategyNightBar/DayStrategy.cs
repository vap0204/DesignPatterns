using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar          //ConcreteStrategy2
{
    public class DayStrategy : NightBarStrategy
    {
        public override void Calculate(double amount)
        {
            Console.WriteLine(amount / 2 + " paid by DayStrategy");
        }
    }
}
