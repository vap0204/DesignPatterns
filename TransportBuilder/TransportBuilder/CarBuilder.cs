using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TransportBuilder
{
    class CarBuilder:Builder //ConcreteBuilder1
    {
        public Product product = new Product();
        public override void BuildFrame()
        {
            product.Frame = "Car Frame";
        }

        public override void BuildEngine()
        {
            product.Engine = "3 000 cc";
        }

        public override void BuildDoors()
        {
            product.Doors = "4";
        }
        public override void BuildWheels()
        {
            product.Wheels = "4";
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}
