using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TransportBuilder
{
    abstract class Builder //Builder
    {
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildDoors();
        public abstract void BuildWheels();
        public abstract Product GetProduct();
    }
}
