using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStructure
{
     class Reciever//Reciever
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Reciever: Working on {a}");
        }
        public void DoSomethinfElse(string b)
        {
            Console.WriteLine($"Reciever:Also Working on {b}");
        }
    }
}
