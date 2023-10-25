using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars
{
     class EuropeFactory:ToyotaFactory//ConcreateFactory2
    {
        public override Toyota CreateModel()
        {
            return new CorollaToyota();//ConcreteProduct2
        }
    }
}
