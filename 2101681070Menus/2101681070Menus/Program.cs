using _2101681070Menus;

namespace _2101681070Menu
{
    class Program
    {
        /*
         * Създайте програма, която създава менюта за хранене.
           Всяко меню може да се състои от хамбургер, картофки, напитка и играчка.
           Създайте менютата на стьпки:
﻿﻿﻿           -Направи хамбургер;
﻿﻿﻿           -Направи картофки;
﻿﻿﻿           -Направи напитка;
﻿﻿﻿           -Добави играчка.
           Покажете на конзолата създадените менюта.
           (Design Pattern->Builder)
         */

        static void Main(string[] args)
        {
            Director director = new Director();
            Builder menu1Builder = new AdultMenuBuilder();
            director.Construct(menu1Builder);
            menu1Builder.GetMenu().PrintInfo();

            Director director1= new Director();
            Builder menu2Builder=new KidsMenuBuilder();
            director.Construct(menu2Builder);
            menu2Builder.GetMenu().PrintInfo();
            Console.ReadKey();
        }
    }

}
