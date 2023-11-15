using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070_PizzaExam
{
    class Pizza//Product
    {
        public string Dough { get; set; }
        public string TommatoSauce { get; set; }
        public string Cheese { get; set; }
        public string Ingredians { get; set;}

        public void PrintInfo()
        {
            Console.WriteLine("Dough:{0}",Dough);
            Console.WriteLine("Tommato Sauce:{0}", TommatoSauce);
            Console.WriteLine("Cheese:{0}", Cheese);
            Console.WriteLine("Ingredians:{0}", Ingredians);
            Console.WriteLine("*******************************");



        }

    }
}
