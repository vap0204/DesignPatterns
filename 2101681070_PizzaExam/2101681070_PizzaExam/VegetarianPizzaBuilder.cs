using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070_PizzaExam
{
   class VegetarianPizzaBuilder:Builder//ConcreteBuilder2
    {
        public Pizza pizza = new Pizza();
        public override void MakeDough()
        {
            pizza.Dough = "Wheat Dough";
        }
        public override void AddTommatoSauce()
        {
            pizza.TommatoSauce = "Yes";
        }
        public override void AddCheese()
        {
            pizza.Cheese = "No";
        }

        public override void AddIngredians()
        {
            pizza.Ingredians = "Tomatoes, Onion, Spinach, Arugula, Corn, Pepper, Peas ";
        }

        public override Pizza GetPizza()
        {
            return pizza;
        }
    }
}
