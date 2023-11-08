using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMehodDrinkingMaker
{
    abstract class HotDrink //AbstractClass
    {
        public void MakeDrink() //TemplateMethod 
        {
            BoilWater();
            AddMainIngredient(); //PrimitiveOperation1
            PourInCup();
            AddSupplement();//PrimitiveOperation2

        }

        public void BoilWater()
        {
            Console.WriteLine("Water is ready!");
        }
        public abstract void AddMainIngredient();
        public void PourInCup()
        {
            Console.WriteLine("Drink is in the cup!");
        }

        public abstract void AddSupplement();   

    }
}
