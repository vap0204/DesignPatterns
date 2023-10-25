using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar          //ConcreteStrategy1
{
    public class NormalStrategy : NightBarStrategy
    {
        public override void Calculate(double amount)
        {
            Console.WriteLine(amount + " paid by NormalStrategy");
        }
    }
}
