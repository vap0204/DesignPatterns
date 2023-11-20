using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070Menus
{
     class AdultMenuBuilder:Builder//ConcreteBuilder2
    {
        public Menu menu = new Menu();
        public override void MakeHamburger()
        {
            menu.Hamburger = "Double ChickenBurger";
        }

        public override void MakeFries()
        {
            menu.Fries = "Big Fries";
        }

        public override void MakeDrink()
        {
            menu.Drink = "Fanta";
        }

        public override void AddToy()
        {
            menu.Toy = "No";
        }

        public override Menu GetMenu()
        {
            return menu;
        }
    }
}
