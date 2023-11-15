using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070_PizzaExam
{
     class Director//Director
    {
        public void Construct(Builder builder)
        {
            builder.MakeDough();
            builder.AddTommatoSauce();
            builder.AddCheese();
            builder.AddIngredians();
        }
    }
}
