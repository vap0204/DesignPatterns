using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar
{
    public class Drink
    {
        public double price;
        public int quantity;
        public Drink( double price, int quantity) 
        { 
            this.price = price;
            this.quantity = quantity;
        }
    }
}
