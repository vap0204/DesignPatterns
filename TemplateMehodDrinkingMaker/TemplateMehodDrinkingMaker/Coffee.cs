using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMehodDrinkingMaker
{
     class Coffee:HotDrink ///ConcreteClass1
    {
        public override void AddMainIngredient()
        {
            Console.WriteLine("Adding Coffee...");
        }
        public override void AddSupplement()
        {
            Console.WriteLine("Adding cream, sugar and milk...");
        }
    }
}
