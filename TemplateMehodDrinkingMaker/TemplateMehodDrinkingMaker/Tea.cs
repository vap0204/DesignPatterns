using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMehodDrinkingMaker
{
  class Tea: HotDrink// ConscreteClass2
    {
        public override void AddMainIngredient()
        {
            Console.WriteLine("Adding Tea...");
        }
        public override void AddSupplement()
        {
            Console.WriteLine("Adding honey...");
        }
    }
}
