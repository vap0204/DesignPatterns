using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStructure
{
     class ComplexCommand:ICommand //ConcreteCommand2
    {
        private Reciever _reciever;
        //Kontekstni danni koito sa nujni za startirane na metodite na  revievera
        private string _a;
        private string _b;

        public ComplexCommand(Reciever reciever, string a, string b)
        {
            _reciever = reciever;
            _a = a;
            _b = b;
        }
        public void Execute() {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a reciever object");

            this._reciever.DoSomething(this._a);
            this._reciever.DoSomethingElese(this._b);


        }

    }
}
