using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2101681070_PizzaExam
{
    abstract class Builder //Builder
    {
        public abstract void MakeDough();
        public abstract void AddTommatoSauce();
        public abstract void AddCheese();
        public abstract void AddIngredians();

        public abstract Pizza GetPizza();
    }
}
