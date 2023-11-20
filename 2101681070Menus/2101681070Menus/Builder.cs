using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070Menus
{
    abstract class Builder//Builder
    {
        public abstract void MakeHamburger();
        public abstract void MakeFries();
        public abstract void MakeDrink();
        public abstract void AddToy();
        public abstract Menu GetMenu();
    }
}
