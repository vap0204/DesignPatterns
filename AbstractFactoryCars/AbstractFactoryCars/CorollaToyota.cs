using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars
{
    internal class CorollaToyota : Toyota
    {
        public override string Name
        {
            get { return "Toyota Corolla"; }
        }
        public override string Model
        {
            get { return "Corolla"; }
        }

        public override string EngineType
        {
            get { return "Petrolic"; }
        }
        public override string Color
        {
            get { return "Grey"; }
        }
        public override void Print()
        {
            Console.WriteLine("The name of my car is: {0}", Name);
            Console.WriteLine("The model is {0}", Model);
            Console.WriteLine("The engine is {0}", EngineType);
            Console.WriteLine("The color is {0}", Color);
        }
    }
}