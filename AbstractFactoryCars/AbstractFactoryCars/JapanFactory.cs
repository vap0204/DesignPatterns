using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars
{
     class JapanFactory:ToyotaFactory //ConcreteFactory 1
    {
        public override Toyota CreateModel()
        {
            return new PriusToyota();//ConcreteProduct1
        }
    }
}
