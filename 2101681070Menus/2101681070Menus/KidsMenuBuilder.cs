using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070Menus
{
    class KidsMenuBuilder:Builder//ConcreteBuilder1
    {
        public Menu menu = new Menu();
        public override void MakeHamburger()
        {
            menu.Hamburger = "Cheeseburger";
        }

        public override void MakeFries()
        {
            menu.Fries = "Small Fries";
        }

        public override void MakeDrink()
        {
            menu.Drink = "Orange Juice";
        }

        public override void AddToy()
        {
            menu.Toy = "Talles for good night";
        }

        public override Menu GetMenu()
        {
            return menu;
        }

    }
}
