using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070Menus
{
    class Menu//Product
    {
        public string Hamburger{get; set;}
        public string Fries { get; set; }
        public string Drink { get; set; }
        public string Toy { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Hamburger: {0}", Hamburger);
            Console.WriteLine("Fries: {0}", Fries);
            Console.WriteLine("Drink: {0}", Drink);
            Console.WriteLine("Toy: {0}", Toy);
            Console.WriteLine("**********************************************");
        }
    }
}
