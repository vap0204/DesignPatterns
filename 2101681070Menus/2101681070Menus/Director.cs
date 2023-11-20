using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070Menus
{
     class Director//Director
    {
        public void Construct(Builder builder)
        {
            builder.MakeHamburger();
            builder.MakeFries();
            builder.MakeDrink();
            builder.AddToy();
        }
    }
}
