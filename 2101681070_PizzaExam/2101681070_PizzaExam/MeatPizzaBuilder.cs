using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070_PizzaExam
{
    class MeatPizzaBuilder : Builder//ConcreteBuilder1
    {
        public Pizza pizza = new Pizza();
        public override void MakeDough()
        {
            pizza.Dough = "Italian Dough";
        }
        public override void AddTommatoSauce()
        {
            pizza.TommatoSauce = "Yes";
        }
        public override void AddCheese()
        {
            pizza.Cheese = "Yes";
        }

        public override void AddIngredians()
        {
            pizza.Ingredians = "Bacon,Chicken,Ham ";
        }

        public override Pizza GetPizza()
        {
            return pizza;
        }
    }
}

